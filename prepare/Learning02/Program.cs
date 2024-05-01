using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "White Star Line";
        job1._jobTitle = "Bilge Operator";
        job1._startYear = 1912;
        job1._endYear = 1912;

        Job job2 = new Job();
        job2._company = "Marv's Muck Mart";
        job2._jobTitle = "Muck Demucker";
        job2._startYear = 2021;
        job2._endYear = 2024;

        Resume resume = new Resume();
        resume._name = "Thaddeus T. Thudpucker";
        resume._job.Add(job1);
        resume._job.Add(job2);

        resume.Display();
    }
}