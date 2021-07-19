---
title: "Voice Channel Frequently Asked Questions | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---


# Voice Channel Frequently Asked Questions and known limitations



Power Virtual Agents as IVR

| **Category**                | **Limitations**                                                               | **Possible workaround**                                                                                                                                           |
|-----------------------------|-------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Geo availability            | U.S. (including Puerto Rico), Canada                                          | Create an environment within the US.                                                                                                                              
   >                                                                                                                                                                  
   > Quality and latency could be affected if the customer is in a different geography outside of US.                                                                 |
| Language                    | English (en-us, en-ca) only                                                   |                                                                                                                                                                   |
| Voice                       | Aria Neural (US)                                                              
  >                                                                              
  > Clara Neural (Canada)                                                        |                                                                                                                                                                   |
| Environment                 | PVA bot should be created in the whitelisted Dynamics OC environment.         |                                                                                                                                                                   |
| Existing bots               | Existing PVA bots cannot be connected in the new voice preview environment.   | Create a new bot in the new environment.                                                                                                                          
   >                                                                                                                                                                  
   > Import an existing bot into the new environment.                                                                                                                 |
| Connecting to Omnichannel   | Supported with no extra steps.                                                |                                                                                                                                                                   |
| Configuring agent handoff   | Supported with no extra steps.                                                |                                                                                                                                                                   |
| Adaptive Cards              | Adaptive cards may not be automatically rendered on voice channel.            | Bot author has to modify the cards to define &lt;[*speak*](https://docs.microsoft.com/en-us/adaptive-cards/authoring-cards/speech#speak-property)&gt; property.   |
| Suggestion actions          | Supported with both voice and DTMF input.                                     |                                                                                                                                                                   |
| Single-digit DTMF           | Supported.                                                                    |                                                                                                                                                                   |

| **Category**                                     | **Limitations**                                                                                                             | **Possible workaround**                                    |
|--------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------|
| Multi-digit DTMF                                 | Not supported.                                                                                                              |                                                            |
| Key mapping to escalate to agent                 | Not supported.                                                                                                              | Must request agent escalation with voice.                  |
| Images/Videos (with markdown)                    | Not supported over voice.                                                                                                   |                                                            |
| Power Automate                                   | Supported.                                                                                                                  |                                                            |
| Bot Skills                                       | Not supported.                                                                                                              |                                                            |
| Long running processes                           | Supported only for less 15 seconds on voice.                                                                                |                                                            |
| Text formatting                                  | Voice channel may pronounce some markdown formatting incorrectly. For example, bullet points are pronounced as asterisks.   | Avoid markdown and complex formatting for voice channel.   |
| Speaking over the bot                            | User voice input will be ignored while the bot is speaking.                                                                 
  >                                                                                                                            
  > Coming soon.                                                                                                               | Wait for the bot to finish speaking before giving input.   |
| Caller ID                                        | Not available during Preview. Coming soon.                                                                                  |                                                            |
| Context passed from OC to PVA during invite      | Not supported.                                                                                                              |                                                            |
| Context passing from PVA to OC during hand-off   | Supported.                                                                                                                  |                                                            |
| Channel specific authoring                       | Not supported.                                                                                                              |                                                            |

| **Category**                          | **Limitations**                                                               | **Possible workaround**   |
|---------------------------------------|-------------------------------------------------------------------------------|---------------------------|
| Use of PVA bot as IVR in production   | Not supported. This is private preview only, meant for testing and feedback   |                           |

