using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jfrost_bugtracker.Models
{
    public class Tickets
    {
        public Tickets()
        {
            this.TicketComment = new HashSet<TicketComments>();
            this.TicketAttachment = new HashSet<TicketAttachments>(); //??
            this.TicketHistory = new HashSet<TicketHistories>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public int OwnerUserId { get; set; }
        public int AssignedToUserId { get; set; }

        public virtual ICollection<TicketComments> TicketComment { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachment { get; set; } //??
        public virtual ICollection<TicketHistories> TicketHistory { get; set; }

        public virtual Projects Project { get; set; }
        public virtual TicketStatuses TicketStatus { get; set; }
        public virtual TicketPriorities TicketPriority { get; set; }
        public virtual TicketTypes TicketType { get; set; }

        public virtual ApplicationUser OwnerUser { get; set; }
        public virtual ApplicationUser AssignedToUser { get; set; }
    }



        public class TicketStatuses
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class TicketPriorities
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class TicketTypes
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        //public class TicketAttachments
        //{
        //    public int Id { get; set; }
        //    public int TicketId { get; set; }
        //    public string FilePath { get; set; }
        //    public string Description { get; set; }
        //    public DateTimeOffset Created { get; set; }
        //    public string UserId { get; set; }
        //    public string FileUrl { get; set; }
        //}

        //public class TicketComments
        //{
        //    public int Id { get; set; }
        //    public string Comment { get; set; }
        //    public int TicketId { get; set; }
        //    public string UserId { get; set; }
        //}

        //public class TicketHistories
        //{
        //    public int Id { get; set; }
        //    public int TicketId { get; set; }
        //    public string Property { get; set; }
        //    public string OldValue { get; set; }
        //    public string NewValue { get; set; }
        //    public bool Changed { get; set; }
        //    public string UserId { get; set; }
        //}

        //public class TicketNotifications
        //{
        //    public int Id { get; set; }
        //    public int TicketId { get; set; }
        //    public string UserId { get; set; }
        //}
    }