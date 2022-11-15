---
title: "Pricing scenarios in | MicrosoftDocs"
description: "Use this topic to understand how pricing is calculated in Omnichannel for Customer Service."
ms.date: 11/02/2021
ms.service: dynamics-365-customerservice
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Pricing Scenarios

Prices for Azure Communication Services are based on a pay-as-you-go model. The prices in the following examples are for illustrative purposes and may not reflect the latest Azure pricing.

## Pricing

Calling and screen-sharing services are charged on a per minute per participant basis at $0.004 per participant per minute for group calls. Azure Communication Services doesn't charge for data egress. To understand the various call flows that are possible, refer to this page.

Each participant of the call will count in billing for each minute they're connected to the call. This holds true regardless of whether the user is video calling, voice calling, or screen-sharing.

### Pricing example: Inbound call from the customer via Microsoft Teams

Mae calls your US toll-free number (acquired from Communication Services) from her Microsoft Teams account. 

- Mae uses Microsoft Teams to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call.
- The call lasts for 20 mins.

**Cost calculations**

- One participant on the Microsoft Teams leg (from Mae)x 20 minutes x rate according to the Teams license.
- One participant on the PSTN leg (inbound from Mae)x 20 minutes x 0.022 per participant per minute = $0.44
- One participant on the VOIP leg (inbound to Matias)x20 x 0.004 per participant per minute= $0.08
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.44 + $0.08 + applicable Teams charges = $0.52 + applicable Teams charges

### Pricing example: Customer calls through Microsoft Teams is transferred from one agent to another a phone call

Mae calls your US toll-free number (acquired from Communication Services) from her Microsoft Teams account. 

- Mae uses Microsoft Teams to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call.
- Matias transfers the call to another human agent, Cole, through a phonecall.
- The call lasts 20 minutes in which Mae talks to Matias for 10 minutes. Matias transfers the call to Cole. Mae talks to Cole for another 10 minutes.

**Cost calculations**

- One participant on the Microsoft Teams leg (from Mae)x 20 minutes x rate according to the Teams license.
- One participant on the PSTN leg (inbound from Mae)x 20 minutes x 0.022 per participant per minute = $0.44
- One participant on the VOIP leg (inbound to Matias)x 10 x 0.004 per participant per minute= $0.04
- One participant on the PSTN leg (inbound to Cole)x 10 x 0.013 per participant per minute= $0.13
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.44 + $0.05 + $ 0.13 + applicable Teams charges = $0.61 + applicable Teams charges

### Pricing example: Inbound call from the customer through a phonecall, call is transferred from one agent to another through Teams

Mae calls your US toll-free number (acquired from Communication Services) from her mobile. 

- Mae uses Microsoft Teams to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. The call recording starts.
- Matias transfers the call to another human agent, Cole, through Microsoft Teams. The call recording stops.
- The call lasts 20 minutes in which Mae talks to Matias for 10 minutes. Matias transfers the call to Cole. Mae talks to Cole for another 10 minutes.

**Cost calculations**

- One participant on the PSTN leg (inbound from Mae)x 20 minutes x 0.022 per participant per minute = $0.44
- One participant on the VOIP leg (inbound to Matias)x 10 x 0.004 per participant per minute= $0.04
- One participant on the Microsoft Teams (inbound to Cole) x 10 x per Teams license
- One participant on the PSTN leg (inbound to Cole)x 10 x 0.013 per participant per minute= $0.13
- Cost to record= 20 x $0.002 per minute = $0.04
- Omnichannel for Customer Service bot does not introduce additional ACS charges. The VOIP leg to the recording bot is not calculated.

**Total cost for the call**: $0.44 + $0.04 + $ 0.13+ $0.04+ applicable Teams charges= $0.65 + applicable Teams charges

### Pricing example: Inbound call from the customer through a phonecall, call is escalated to a human agent from an IVR bot

Mae calls your US toll-free number (acquired from Communication Services) from her mobile. 

- Mae uses her mobile phone to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a Power Virtual Agent bot to the call. The customer interacts with the bot for 2 minutes.
- The Power Virtual Agent bot escalates the call to a human agent, Matias. The call lasts for 8 minutes.
- Matias transfers the call to another human agent, Cole, through Microsoft Teams. The call recording stops.
- The call lasts 10 minutes.
**Cost calculations**

- One participant on the PSTN leg (inbound from Mae)x 10 minutes x 0.022 per participant per minute = $0.22
- One participant on the VOIP leg (inbound to Power Virtual Agents bot) X 2 x $ 0.004 per minute = $0.008
- One participant on the VOIP leg (inbound to Matias )x 8 x 0.004 per participant per minute= $0.032
- Omnichannel for Customer Service bot does not introduce additional ACS charges. The VOIP leg to the recording bot is not calculated.

**Total cost for the call**: $0.22 + $0.008 + $ 0.032+ $0.04= $0.26

### Pricing example: Customer calls through Microsoft Teams, Supervisor joins the call to monitor the conversation

Mae calls your US toll-free number (acquired from Communication Services) from her Teams account. 

- Mae uses Microsoft Teams to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. 
- Matias' supervisor, Gaby, joins the call to monitor the conversation.  
- The call lasts 10 minutes in which Mae talks to Matias for 10 minutes. 

**Cost calculations**

- One participant on the Microsoft Teams leg (from Mae)x 10 minutes x rate according to the Teams license.
- One participant on the PSTN leg (inbound from Mae)x 10 minutes x 0.022 per participant per minute = $0.22
- One participant on the VOIP leg (inbound to Matias)x 10 x 0.004 per participant per minute= $0.04
- One participant on the VOIP leg (Gaby joins to consult)x 10 x 0.004 per participant per minute= $0.04
  Note: This leg is charged only when Gaby joins the call.
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.22 + $0.04 + $ 0.04 + applicable Teams charges = $0.30+ applicable Teams charges

### Pricing example: Customer calls from Microsoft Teams, Supervisor is invited to consult the conversation

Mae calls your US toll-free number (acquired from Communication Services) from her mobile. 

- Mae uses her mobile to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. Matias starts call recording.
- Matias' supervisor, Gaby, joins the call to monitor the conversation. 
- The call lasts 10 minutes.

**Cost calculations**

- One participant on the Microsoft Teams leg (from Mae)x 10 minutes x rate according to the Teams license.
- One participant on the PSTN leg (inbound from Mae)x 10 minutes x 0.022 per participant per minute = $0.22
- One participant on the VOIP leg (inbound to Matias)x 10 x 0.004 per participant per minute= $0.04
- One participant on the VOIP leg (Gaby joins to consult)x 10 x 0.004 per participant per minute= $0.04
  Note: This leg is charged only when Gaby joins the call.
- Cost to record= 10 x $0.002 per minute = $0.02
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.22 + $0.04 + $0.04 + $0.02  + applicable Teams charges = $0.32 + applicable Teams charges

### Pricing example: Customer calls from a mobile, Supervisor is invited to consult the conversation

Mae calls your US toll-free number (acquired from Communication Services) from her mobile. 

- Mae uses her mobile to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. Matias starts call recording.
- Matias adds his supervisor, Gaby, to consult on the call. 
- The call lasts 20 minutes in which Mae talks to Matias for 10 minutes, before Gaby is added on to the call. The call then goes on for another 10 minutes.

**Cost calculations**

- One participant on the PSTN leg (inbound from Mae)x 20 minutes x 0.022 per participant per minute = $0.44
- One participant on the VOIP leg (inbound to Matias)x 20 x 0.004 per participant per minute= $0.08
- One participant on the VOIP leg (Gaby joins to consult)x 10 x 0.004 per participant per minute= $0.04
  Note: This leg is charged only when Gaby joins the call.
- Cost to record= 20 x $0.002 per minute = $0.04
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.44 + $0.08 + $0.04 + $0.04 = $0.60


### Pricing example: Customer calls from a Teams account, call is transferred to an agent through Teams PSTN

Mae calls your US toll-free number (acquired from Communication Services) from her Teams account. 

- Mae uses her Teams account to make the call.
- Omnichannel for Customer Service bot starts new incoming call via direct routing.
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. Matias starts call recording.
- Matias transfers the call to another agent, Cole.
- The call lasts 10 minutes in which Mae talks to Matias for 5 minutes, before he transfers the call tCole. The call then goes on for another 5 minutes.

**Cost calculations**

- - One participant on the Microsoft Teams leg (from Mae)x 10 minutes x rate according to the Teams license.
- One participant on the PSTN leg (inbound from Mae)x 10 minutes x 0.022 per participant per minute = $0.22
- One participant on the VOIP leg (inbound to Matias)x 5 x 0.004 per participant per minute= $0.02
- One participant on the PSTN leg (inbound to Cole)x 5 x 0.013 per participant per minute= $0.065
  Note: This leg is charged only when Gaby joins the call.
- Cost to record= 10 x $0.002 per minute = $0.02
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.22 + $0.02 + $0.065 + $0.02  + applicable Teams charges = $0.325  + applicable Teams charges


### Pricing example: Customer calls from a Teams account, call is transferred to an agent through Teams PSTN

Mae calls your US toll-free number (acquired from Communication Services) from her Teams account. 

- Mae uses her Teams account to make the call.
- Call goes to a Session Border Controller (SBC) connected to ACS
- Omnichannel for Customer Service bot adds a human agent, Matias to a call. 
- The call lasts 10 minutes.

**Cost calculations**

- One participant on the PSTN leg (inbound from Mae to SBC)x 10 x rate per the contract with carrier 
- One participant on the PSTN leg (SBC to ACS)x 10 x rate per the contract with carrier
- One participant on the SIP leg (SBC to ACS)x 10 x 0.022 per participant per minute= $0.22
- One participant on the VOIP leg (inbound to Matias)x 5 x 0.013 per participant per minute= $0.065
  Note: This leg is charged only when Gaby joins the call.
- Cost to record= 10 x $0.002 per minute = $0.02
- Omnichannel for Customer Service bot does not introduce additional ACS charges.

**Total cost for the call**: $0.22 + $0.02 + $0.065 + $0.02  + applicable Teams charges = $0.325  + applicable Teams charges

