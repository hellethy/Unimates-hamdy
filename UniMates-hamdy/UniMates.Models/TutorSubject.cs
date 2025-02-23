﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniMates.Models
{
    public class TutorSubject : BaseEntity
    {
        public Guid TutorId { get; set; } = Guid.NewGuid();
        public Guid SubjectId { get; set; } = Guid.NewGuid();
        // Navigation properties

        public User ?Tutor { get; set; }
        public Subject? Subject { get; set; }

    }
}
