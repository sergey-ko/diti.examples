# Examples for DiTi platform

[DiTi](https://diti.dev) simplifies creation and maintenance of near real-time digital twins for IIoT.

<div style="padding:56.25% 0 0 0;position:relative;"><iframe src="https://player.vimeo.com/video/494004592?badge=0&amp;autopause=0&amp;quality_selector=1&amp;player_id=0&amp;app_id=58479" frameborder="0" allow="autoplay; fullscreen; picture-in-picture" style="position:absolute;top:0;left:0;width:100%;height:100%;" title="Digital Twins Platform"></iframe></div><script src="https://player.vimeo.com/api/player.js"></script>

## Example 1 : flow messages from AMQP to AMQP

Simple example of recieving messages in one AMQP queue and send them to another AMQP queue.


## Example 2 : simulation of 'simple pedulum'

Pendulum model from 'simplependulum.fmu' is simulated with 500ms steps.
Simulation data ('x' and 'y') is sens to Redis TimeSeries and them visualize in Grafana

![pendulum x and y](pics/pendulum_grafana.jpg)

