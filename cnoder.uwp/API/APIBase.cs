using cnoder.uwp.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cnoder.uwp.API
{
    
    abstract class  APIBase:HttpHelper
    {
        const string apiHost = "http://cnodejs.org/api/v1";
        protected  String TOPICS = $"{apiHost}/topics";
        protected  String TOPIC = $"{apiHost}/topic";
        protected  String REPLY_2_TOPIC = $"{apiHost}/topic";
        protected  String ADD_COLLECT = $"{apiHost}/topic_collect/collect";
        protected  String DEL_COLLECT = $"{apiHost}/topic_collect/de_collect";
        protected  String USER_COLLECT = $"{apiHost}/topic_collect";
        protected  String AGREE_REPLY = $"{apiHost}/reply";
        protected  String AUTHORIZE = $"{apiHost}/accesstoken";
        protected  String USER = $"{apiHost}/user";
        protected  String MESSAGES = $"{apiHost}/messages";
        protected  String MESSAGE_COUNT = $"{apiHost}/message/count";
        protected  String MARK_ALL_MESSAGE = $"{apiHost}/message/mark_all";
    }
}
