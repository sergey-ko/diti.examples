using System.Collections.Generic;
using SBCE.DT.Host.Projects;
using SCBE.Actors.DT.SimulatedDigitalTwin;
using SCBE.Common.Models;

namespace DiTi.Examples
{
    public class Pendulum :  DiTiPlatformProject
    {
        public override void Init()
        {
            var amqpSink = CreateAmqpSink("amqp-sink");
            var mqttSink = CreateMqttSink("mqtt-sink");
            var redisSink = CreateRedisTsSink("redis-sink");
 
            var dtmConfig = new SimulateDtTeamConfig
            {
                NumberOfTwinsToSimulate = 1,
                SimulateDtConfig = new SimulatedTwinConfig
                {
                    ModelId = "SimplePendulum",
                    Interval = 500,
                    P2Mappings = ParameterToMeasurementMapping.CreateList(new Dictionary<string, string>{{"x","X"},{"y","Y"}}),
                    InitialState = ParameterValue.CreateNamedValueList(new Dictionary<string, double>{{"l",10}})
                }
            };

            var dtM = CreateSimulateDt("pendulum-sim", dtmConfig);

            AddStreamConnection(dtM, amqpSink);
            AddStreamConnection(dtM, mqttSink);
            AddStreamConnection(dtM, redisSink);
        }
    }
}