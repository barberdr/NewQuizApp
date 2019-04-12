using System;
using System.Collections.Generic;
using System.Text;

namespace NewQuizApp
{
    class CompTIA220901QuizQuestions
    {
        public string[] GetDomainQuestion(int domainNumber, int questionNumber)
        {
            // get the correct domain array
            var domain = GetDomain(domainNumber);
            // validate question number is in the appropriate range
            if (questionNumber < 0 || questionNumber > domain.Length)
            {
                throw new InvalidOperationException("Invalid Question Number");
            }
            return domain[questionNumber];
        }

        public int NumberOfQuestionsInDomain(int domainNumber)
        {
            //get the correct domain
            var domain = GetDomain(domainNumber);
            return domain.Length;
        }

        // this function can be either a switch (like you have in the quiz engine) or several if statements
        // I went with the if statment in this case, but either works
        private string[][] GetDomain(int domain)
        {
            switch(domain)
            {
                case 1:
                    return Domain1Hardware;
                case 2:
                    return Domain2Networking;
                case 3:
                    return Domain3MobileDevicess;
                case 4:
                    return Domain4HardwareandNetworkTroubleshooting;
                default:
                    throw new InvalidOperationException("Invalid Domain");
            }
        }


        //The first value of each question array is the question
        //The last value in each question array is the correct answer

        #region Domain1Hardware

        private readonly string[][] Domain1Hardware = new string[3][]
        {
            new string[]
            {
                "Which of these connection types would you most commonly associate with NAS?",
                "Ethernet",
                "eSATA",
                "USB",
                "FireWire",
                "Serial",
                "Ethernet"
                //"NAS (Network Address Storage) is accessible across the network, so one of the most common NAS connections is over Ethernet./n
                //220-901, Objective 1.11 - Device Connectors and Cables/n
                //https://www.professormesser.com/free-a-plus-training/220-901/device-connectors-and-cables-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "If you had four identical drives, which of these RAID types would provide both redundancy and the most available storage space for your data?",
                "RAID 0",
                "RAID 1",
                "RAID 5",
                "RAID 1 + 0",
                "RAID 5"
                //"RAID	0 does not provide redundancy, and RAID 1 and 1+0 are mirroring data and therefore are effectively limiting available storage space by 50%. RAID 5 also provides redundancy, but it only uses the space of a single drive for the redundant parity data. With four drives, this means that RAID 5 would provide data storage that was equal to three of the four disks, or 75% of the total disk space./n
                //220-901, Objective 1.5 - An Overview of RAID/n
                //https://www.professormesser.com/free-a-plus-training/220-901/an-overview-of-raid-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "You have just purchased a new dual-core PC, but when you look at the Windows Task Manager's Performance tab, you see usage statistics for four CPUs. What would be the most likely cause of this difference?",
                "Dual-core CPUs appear as four separate CPUs in Windows ",
                "The dual-core CPUs are using HTT",
                "The new computer uses dual-channel memory",
                "The dual-core CPUs are using HTT"
                //"Hyper-Threading Technology is designed to allow a single CPU to schedule two processes at the same time, allowing the system to share the workload between both threads. If you view an HTT-enabled CPU in Task Manager, it will appear as if the computer has two or more CPUs for every physical CPU./n
                //220-901, Objective 1.6 - Understanding CPU Characteristic/n
                //https://www.professormesser.com/free-a-plus-training/220-901/understanding-cpu-characteristics-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            }
         };

        #endregion

        #region Domain2Networking

        private readonly string[][] Domain2Networking = new string[3][]
        {
            new string[]
            {
                "Which of these connection types would you most commonly associate with NAS?",
                "Ethernet",
                "eSATA",
                "USB",
                "FireWire",
                "Serial",
                "Ethernet"
                //"NAS (Network Address Storage) is accessible across the network, so one of the most common NAS connections is over Ethernet./n
                //220-901, Objective 1.11 - Device Connectors and Cables/n
                //https://www.professormesser.com/free-a-plus-training/220-901/device-connectors-and-cables-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "If you had four identical drives, which of these RAID types would provide both redundancy and the most available storage space for your data?",
                "RAID 0",
                "RAID 1",
                "RAID 5",
                "RAID 1 + 0",
                "RAID 5"
                //"RAID	0 does not provide redundancy, and RAID 1 and 1+0 are mirroring data and therefore are effectively limiting available storage space by 50%. RAID 5 also provides redundancy, but it only uses the space of a single drive for the redundant parity data. With four drives, this means that RAID 5 would provide data storage that was equal to three of the four disks, or 75% of the total disk space./n
                //220-901, Objective 1.5 - An Overview of RAID/n
                //https://www.professormesser.com/free-a-plus-training/220-901/an-overview-of-raid-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "You have just purchased a new dual-core PC, but when you look at the Windows Task Manager's Performance tab, you see usage statistics for four CPUs. What would be the most likely cause of this difference?",
                "Dual-core CPUs appear as four separate CPUs in Windows ",
                "The dual-core CPUs are using HTT",
                "The new computer uses dual-channel memory",
                "The dual-core CPUs are using HTT"
                //"Hyper-Threading Technology is designed to allow a single CPU to schedule two processes at the same time, allowing the system to share the workload between both threads. If you view an HTT-enabled CPU in Task Manager, it will appear as if the computer has two or more CPUs for every physical CPU./n
                //220-901, Objective 1.6 - Understanding CPU Characteristic/n
                //https://www.professormesser.com/free-a-plus-training/220-901/understanding-cpu-characteristics-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            }
         };

        #endregion

        #region Domain3MobileDevices

        private readonly string[][] Domain3MobileDevicess = new string[3][]
        {
            new string[]
            {
                "Which of these connection types would you most commonly associate with NAS?",
                "Ethernet",
                "eSATA",
                "USB",
                "FireWire",
                "Serial",
                "Ethernet"
                //"NAS (Network Address Storage) is accessible across the network, so one of the most common NAS connections is over Ethernet./n
                //220-901, Objective 1.11 - Device Connectors and Cables/n
                //https://www.professormesser.com/free-a-plus-training/220-901/device-connectors-and-cables-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "If you had four identical drives, which of these RAID types would provide both redundancy and the most available storage space for your data?",
                "RAID 0",
                "RAID 1",
                "RAID 5",
                "RAID 1 + 0",
                "RAID 5"
                //"RAID	0 does not provide redundancy, and RAID 1 and 1+0 are mirroring data and therefore are effectively limiting available storage space by 50%. RAID 5 also provides redundancy, but it only uses the space of a single drive for the redundant parity data. With four drives, this means that RAID 5 would provide data storage that was equal to three of the four disks, or 75% of the total disk space./n
                //220-901, Objective 1.5 - An Overview of RAID/n
                //https://www.professormesser.com/free-a-plus-training/220-901/an-overview-of-raid-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "You have just purchased a new dual-core PC, but when you look at the Windows Task Manager's Performance tab, you see usage statistics for four CPUs. What would be the most likely cause of this difference?",
                "Dual-core CPUs appear as four separate CPUs in Windows ",
                "The dual-core CPUs are using HTT",
                "The new computer uses dual-channel memory",
                "The dual-core CPUs are using HTT"
                //"Hyper-Threading Technology is designed to allow a single CPU to schedule two processes at the same time, allowing the system to share the workload between both threads. If you view an HTT-enabled CPU in Task Manager, it will appear as if the computer has two or more CPUs for every physical CPU./n
                //220-901, Objective 1.6 - Understanding CPU Characteristic/n
                //https://www.professormesser.com/free-a-plus-training/220-901/understanding-cpu-characteristics-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            }
         };

        #endregion

        #region Domain4HardwareandNetworkTroubleshooting

        private readonly string[][] Domain4HardwareandNetworkTroubleshooting = new string[3][]
        {
            new string[]
            {
                "Which of these connection types would you most commonly associate with NAS?",
                "Ethernet",
                "eSATA",
                "USB",
                "FireWire",
                "Serial",
                "Ethernet"
                //"NAS (Network Address Storage) is accessible across the network, so one of the most common NAS connections is over Ethernet./n
                //220-901, Objective 1.11 - Device Connectors and Cables/n
                //https://www.professormesser.com/free-a-plus-training/220-901/device-connectors-and-cables-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "If you had four identical drives, which of these RAID types would provide both redundancy and the most available storage space for your data?",
                "RAID 0",
                "RAID 1",
                "RAID 5",
                "RAID 1 + 0",
                "RAID 5"
                //"RAID	0 does not provide redundancy, and RAID 1 and 1+0 are mirroring data and therefore are effectively limiting available storage space by 50%. RAID 5 also provides redundancy, but it only uses the space of a single drive for the redundant parity data. With four drives, this means that RAID 5 would provide data storage that was equal to three of the four disks, or 75% of the total disk space./n
                //220-901, Objective 1.5 - An Overview of RAID/n
                //https://www.professormesser.com/free-a-plus-training/220-901/an-overview-of-raid-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            },
            new string[]
            {
                "You have just purchased a new dual-core PC, but when you look at the Windows Task Manager's Performance tab, you see usage statistics for four CPUs. What would be the most likely cause of this difference?",
                "Dual-core CPUs appear as four separate CPUs in Windows ",
                "The dual-core CPUs are using HTT",
                "The new computer uses dual-channel memory",
                "The dual-core CPUs are using HTT"
                //"Hyper-Threading Technology is designed to allow a single CPU to schedule two processes at the same time, allowing the system to share the workload between both threads. If you view an HTT-enabled CPU in Task Manager, it will appear as if the computer has two or more CPUs for every physical CPU./n
                //220-901, Objective 1.6 - Understanding CPU Characteristic/n
                //https://www.professormesser.com/free-a-plus-training/220-901/understanding-cpu-characteristics-2/"
                //NOTE: NEED TO HAVE THE ABOVE LINK ADDED HAS HYPERLINK TO STRING AND OPEN A NEW TAB IN BROWSER.
            }
         };

        #endregion
    }
}
