public class Resume
{

    public string _name;

    public List<Job> _jobs = new List<Job>();

    public void DisplayJobHistory()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs: {_jobs}");

        foreach (Job job in _jobs)
        {
            job.DisplayJobHistory();
        }
    }
}