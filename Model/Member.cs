using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Member
    {
        public Member()
        {
        }
        public Member(string memberName, string memberLastName, string memberCellPhone, string memberLibraryId)
        {
            this.memberName = memberName;
            this.memberLastName = memberLastName;
            this.memberCellPhone = memberCellPhone;
            this.memberLibraryId = memberLibraryId;
        }

        public string memberName { get; set; }
        public string memberLastName { get; set; }
        public string memberCellPhone { get; set; }
        public string memberLibraryId { get; set; }
    }
}

