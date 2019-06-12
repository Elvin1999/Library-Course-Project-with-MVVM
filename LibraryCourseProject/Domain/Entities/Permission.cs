﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryCourseProject.Entities
{
    public class Permission
    {
        public int Id { get; set; }
        public int No { get; set; }
        public bool CanCreateBook { get; set; } = false;
        public bool CanCreateUser { get; set; } = false;
        public bool CanCreateFilial { get; set; } = false;
        public bool CanCreateClient { get; set; } = false;
        public bool CanCreateWorker { get; set; } = false;
        public string CreateBook
        {
            get
            {

                if (CanCreateBook)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string CreateUser
        {
            get
            {
                if (CanCreateUser)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
        public string CreateFilial
        {
            get
            {

                if (CanCreateFilial)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }
        public string CreateClient
        {
            get
            {
                if (CanCreateClient)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }

            }
        }
        public string CreateWorker
        {
            get
            {

                if (CanCreateWorker)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
        }
    }
}