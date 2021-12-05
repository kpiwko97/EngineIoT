<h1 align="center">
INTERNET OF THINGS – SUPERVISION OF MECHATRONIC SYSTEMS
</h1>

### 📙 About system:
System has been developed that allows the monitoring
and real-time data collection of the CLBLDC motor. The readings of winding temperature, current, voltage, speed were stored on a storage medium or using wireless communication.
</br>

A notification system has been developed to inform the user of any malfunctions so that a major failure can be prevented in advance. The collected data will allow future assessment of motor performance, lifetime, wear and tear and much more. 

</br>

<p float="left">
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142881784-39bb0658-8e10-4842-9853-44cd32fbe237.png" width="49%" height="800px" />
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142881786-8d8e933a-02a6-401f-937a-817620d0a20a.png" width="49%" height="800px" />
</p>

The entire design consists of the following components: a CLBLDC motor, a motor controller motherboard with an ESP-WROOM 32 module attached, an LCD display soldered to a DS1307 subassembly, and a micro SD card reader. A temperature sensor was attached to the windings, measuring the current winding temperature value.
The idea was developed with a control algorithm, selected electronic and electrical components, and a 3D model, a constructed security system operating in the thinking of the Internet of Things. In detail, the implemented list include.

<p align="center">
<img alt="Credentials" src="https://user-images.githubusercontent.com/38471368/142888804-73a137b6-eec1-46f9-a07c-d0042c4e5371.png"  height="auto" />
</p>

The above picture shows a view of the running application. At the very top is the navigation bar, allowing you to freely navigate through the application. Below are all the motor identification data that have been placed 
in EEPROM memory. The unique identification key GUID of the motor, winding resistance, number of windings, shaft diameter. On the right side there are two graphs: a meter, showing the current value of the rotational speed 
and voltage in volts. At the bottom is a graph of temperature versus time in degrees Celsius.</br>

<p align="center">
<img alt="Credentials" src="https://user-images.githubusercontent.com/38471368/144757557-5b52f0c9-5acc-4878-83f2-261b420b4d81.png" />
</p>


### 🔔 Notifications:

The implementation of the e-mail notifications module with the help of the IFTTT web-service is shown in the diagram. First, the e-mail address to which notifications will be sent was subscribed. Then, in the wizard, the service responsible for waiting for the event has been created.  The configuration is based on linking together two services: Webhook and Email 

<p float="left">
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142881772-aea8c391-a63d-48aa-b131-dba402efdfd5.png" width="49%" height="auto" />
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142890299-1a7d58c7-90ee-48a5-ba45-e159a2b86c19.png" width="49%" height="auto" />
</p>

### 📈 Results:

The engine operating parameters are stored in a text file. Each line consists of respectively: Motor ID, date of recording, voltage, current, speed and winding temperature values. 

<p align="center">
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142881775-270b2474-c3ae-4ef6-b817-deeeb481b1d1.png" width="100%" height="auto" />
<img alt="engine iot" src="https://user-images.githubusercontent.com/38471368/142881777-b505df8e-320f-4b1a-8fcd-68ed29d54c00.png" width="100%" height="auto" />
</p>
