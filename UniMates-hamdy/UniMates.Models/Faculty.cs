﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class Faculty : BaseEntity
    {
       
        public string ?Name { get; set; }
        public Guid UniversityId { get; set; }
        // Navigation properties
        [JsonIgnore]
        [IgnoreDataMember]
        public University ?University { get; set; }

        //Collection navigation property
        public virtual ICollection<Subject>? Subjects { get; set; }
        public virtual ICollection<User>? Users { get; set; }

    }
}
