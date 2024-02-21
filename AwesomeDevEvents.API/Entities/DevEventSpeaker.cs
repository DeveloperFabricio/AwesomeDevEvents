namespace AwesomeDevEvents.API.Entities
{
    public class DevEventSpeaker
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? TalkTitle { get; set; }
        public string? TalsDescription { get; set; }
        public string? LinkedinProfile { get; set; }
        public Guid DevEventId { get; set; }

    }
}