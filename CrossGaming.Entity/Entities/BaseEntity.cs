using CrossGaming.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrossGaming.Entity.Entities
{
    public class BaseEntity: IEntity
    {
        public int ID { get; set; }

        private DateTime _createdDate = DateTime.Now;
        public DateTime CreatedDate
        {
            get
            {
                return _createdDate;
            }
            set
            {
                _createdDate = value;
            }
        }

        private bool _isDeleted = false;
        public bool IsDeleted
        {
            get
            {
                return _isDeleted;
            }
            set
            {
                _isDeleted = value;
            }
        }

        public DateTime? DeletedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
