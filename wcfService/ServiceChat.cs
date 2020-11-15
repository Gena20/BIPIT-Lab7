using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace wcfService
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        List<ServerUser> users = new List<ServerUser>();
        int nextId = 1;

        public int Connect(string name)
        {
            ServerUser user = new ServerUser()
            {
                ID = nextId++,
                Name = name,
                OperationContext = OperationContext.Current
            };
            users.Add(user);
            SendMsg($"{user.Name} connected,", 0);

            return user.ID;
        }

        public void Disconnect(int id)
        {
            var curUser = users.FirstOrDefault(user => user.ID == id);
            
            if (curUser != null)
            {
                users.Remove(curUser);
                SendMsg($"{curUser.Name} disconnected", 0);
            }
        }

        public void SendMsg(string msgText, int fromId)
        {
            var fromUser = users.FirstOrDefault(user => user.ID == fromId);
            foreach (var user in users)
            {
                var nowDate = DateTime.Now.ToShortTimeString();
                var msg = $"{nowDate}: {fromUser?.Name} {msgText}";

                user.OperationContext.GetCallbackChannel<IServerChatCallback>().MsgCallback(msg);
            }
        }
    }
}
