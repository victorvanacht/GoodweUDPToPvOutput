# GoodweUDPToPvOutput
 A tool to use the local network to query the inverter.
 
 Based on work by msatter on https://gathering.tweakers.net/forum/list_message/67162456#67162456 and ThinkPad https://gathering.tweakers.net/forum/list_message/67168926#67168926
 
 Tested with XS inverters with version numbers v1.52.14 and newer, open a ticket at Goodwe to have them update your inverter if your version is lower.
 It appears that the last dot (.14) is most significant and refers to the ARM program that contains the communication code.

# Usage

```
GoodweUdpPoller:
  Tool for querying Goodwe inverters over the local network. Without options set, will try to discover any responding
  inverters on the network and display current telemetry for the last one. Intended use is to invoke in a cronjob
  every 5 minutes to update PVOutput.org, but can be adapted to other uses as it outputs json by default.

Usage:
  GoodweUdpPoller.exe [options]

Options:
  --host <host>                                    IP address, hostname or subnet broadcast address of the inverter.
                                                   If unset, will broadcast a discovery packet to find any compatible
                                                   inverter
  --timeout <timeout>                              Listen timeout for replies
  --pvoutput-system-id <pvoutput-system-id>        System Id for API access on pvoutput.org, see
                                                   https://pvoutput.org/help/api_specification.html
  --pvoutput-apikey <pvoutput-apikey>              API key for API access on pvoutput.org, see
                                                   https://pvoutput.org/help/api_specification.html
  --pvoutput-request-url <pvoutput-request-url>    optional url to post to
  --version                                        Display version information
  --logfilename <local file name>                  The name of the local log file to which a log entry should be written.
                                                   (Existing file will be appended. If file does not exist a new file will be created.)
  --verbatim <true|false>                          Default: false. When true every log item is also displayed on the screen
  --interval <interval_time>                       Interval time in seconds between subsequent log entries.
                                                   When set to 0, only one log entry will be created and program will exit._

```
  **Example 1**:
  `GoodweUdpPoller.exe --host=192.168.2.123 --pvoutput-apikey=234abc123abcdef456789abcdef01234567abcde --pvoutput-system-id=12345`
  
  **Response:**
```
{
  "Temperature": 19.8,
  "Status": 0,
  "EnergyLifetime": 390.4,
  "EnergyToday": 3.2,
  "Power": 92,
  "Iac": 0.6,
  "Vac": 236.7,
  "GridFrequency": 49.98,
  "Ipv": 0.2,
  "Vpv": 197.9,
  "Timestamp": "2021-05-19T19:13:52+01:00",
  "ResponseIp": "192.168.2.123"
}
<=OK 200: Added Status
```
  **Example 2**:
  `GoodweUdpPoller.exe --logfilename e:\goodwelog.txt --verbatim false --interval 300`
  
  **Response:**
```
```
 A log file will be created with a new log entry every 5 minutes


## Installation
A working PVOutput account is assumed.

Extract the executable to a suitable place.
For a first run, you can run it without arguments:
```
$ ./GoodweUdpPoller
```
It should discover your inverter.

Adapt the included `pollgoodwe.sh` script to use your PVOutput settings.

Schedule the script to run on your configured interval (either 5 or 15 minutes):
```
$ crontab -e
```

A sample cron line to push every five minutes:
```
*/5 *   *   *   *    /home/pi/goodweudppoller/pollgoodwe.sh
```
Make sure the path to the script is correct.

## Changes in fork by Victor van Acht
This is a Github fork from the original by Koen van Leeuwen [koen-lee]. <https://github.com/koen-lee/GoodweUDPToPvOutput>

Modifications in this fork are:

- Read out parameters from both PV-string, and all 3 phases from 3-phase inverters.
- Logging to local file
- Verbatim command line option (defaults to false)
- Interval command line option (so configuring cron job is not needed)
