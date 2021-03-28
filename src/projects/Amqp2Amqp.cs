using SBCE.DT.Host.Projects;

namespace DiTi.Examples
{
    public class Amqp2Amqp : DiTiPlatformProject
    {
        public override void Init()
        {
            var amqpSink = CreateAmqpSink("amqp-sink");
            var amqpSource = CreateAmqpSource("amqp-source");
            AddStreamConnection(amqpSource, amqpSink);
        }
    }
}