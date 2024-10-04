class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "influencer";
        job._company = "instagram";
        job._startYear = "2015";
        job._endYear = "2016";

        Job job2 = new Job();
        job2._jobTitle = "baller";
        job2._company = "New York Jets";
        job2._startYear = "2016";
        job2._endYear = "2023";

        Resume myResume = new Resume();
        myResume._name = "Austin Jonas";

        myResume._jobs.Add(job);
        myResume._jobs.Add(job2);

        myResume.DisplayJobHistory();
    }
}