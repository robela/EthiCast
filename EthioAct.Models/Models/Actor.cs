using System;
using System.Collections.Generic;

namespace EthioAct.Models.Models
{
    public partial class Actor
    {
        public Actor()
        {
            this.ActorVSImages = new List<ActorVsImage>();
            this.ActorVsTalents = new List<ActorVsTalent>();
            this.ActorVSVideos = new List<ActorVSVideo>();
        }

        public int actorID { get; set; }
        public string userId { get; set; }
        public string firstName { get; set; }
        public string secondName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> dateOfBirth { get; set; }
        public string gender { get; set; }
        public Nullable<double> height { get; set; }
        public Nullable<double> weight { get; set; }
        public string aboutMe { get; set; }
        public string educationLevel { get; set; }
        public Nullable<int> addressId { get; set; }
        public string emailAddress { get; set; }
        public string emailAddress2 { get; set; }
        public string faceBookAddress { get; set; }
        public string googlePluseAddress { get; set; }
        public string twitterAddress { get; set; }
        public virtual Address Address { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual ICollection<ActorVsImage> ActorVSImages { get; set; }
        public virtual ICollection<ActorVsTalent> ActorVsTalents { get; set; }
        public virtual ICollection<ActorVSVideo> ActorVSVideos { get; set; }
    }
}
