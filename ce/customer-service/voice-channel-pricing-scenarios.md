---
title: Pricing scenarios for voice calling | MicrosoftDocs
description: Use this article to understand how pricing works in the voice channel.
author: gandhamm 
ms.author: mgandham
ms.reviewer: neeranelli
ms.topic: conceptual
ms.date: 06/27/2023 
ms.custom: bap-template 
---

# Pricing scenarios for voice calling

The Dynamics 365 Customer Service voice channel is built on Azure Communication Services. Billing for Azure Communication Services uses a pay-as-you-go model and varies per [country](https://github.com/Azure/Communication/blob/master/pricing/communication-services-pstn-rates.csv). Calling and screen-sharing services are billed per minute per participant. More information: [Pricing Scenarios](/azure/communication-services/concepts/pricing).

 Azure Communication Services doesn't charge for data egress.

[Several call flows are possible](https://go.microsoft.com/fwlink/p/?LinkId=866544). This article describes pricing calculations for the following call scenarios:

- [Inbound: A customer calls from a mobile device; an IVR bot escalates the call to a human agent](#inbound-customer-calls-from-a-mobile-call-is-escalated-to-a-human-agent-from-an-ivr-bot)
- [Inbound: A customer calls from Microsoft Teams](#inbound-a-customer-calls-from-microsoft-teams)
- [Inbound: A customer calls from Teams; a supervisor joins the call to monitor the conversation](#inbound-a-customer-calls-from-teams-a-supervisor-joins-the-call-to-monitor-the-conversation)
- [Inbound: A customer calls from a mobile device; the supervisor is invited to consult](#inbound-a-customer-calls-from-a-mobile-device-the-supervisor-is-invited-to-consult)
- [Inbound: A customer calls from Teams; the call is transferred to an agent through Teams PSTN](#inbound-a-customer-calls-from-teams-the-call-is-transferred-to-an-agent-through-teams-pstn)
- [Outbound: An agent calls a customer](#outbound-an-agent-calls-a-customer)
- [Inbound: Azure direct routing](#inbound-azure-direct-routing)
- [Outbound: Azure direct routing](#outbound-azure-direct-routing)

The following table summarizes the pricing for each scenario.The prices in the following examples are for illustrative purposes and may not reflect the latest Azure pricing in your region.

|Scenario  | Price   |
|----------|-----------|
|PSTN inbound    | $0.022 per minute      |
|PSTN outbound    | $0.013 per minute      |
|VOIP inbound| $0.004 per minute   |
|SBC to Azure Communication Services | $0.004 per minute   |
|ROW Consumption Unit – Inbound -> PSTN inbound rate |  $0.022 per minute |
| App to App Group Calling User Minute –> VOIP rate | $0.004 per minute |
|ROW Consumption Unit – Outbound –> PSTN outbound rate | $0.013 per minute|
|Single Channel Mixed Audio Recording –> Recording rate| $0.004 per minute   |
 
## Inbound: Customer calls from a mobile, call is escalated to a human agent from an IVR bot

Mae calls your Azure Communication Services US toll-free number from a mobile device. The call is routed to a Power Virtual Agents interactive voice response (IVR) bot. Mae interacts with the bot for two minutes. The bot escalates the call to a human agent, Matias. This call lasts eight minutes.

:::image type="content" source="media/Customer-call-escalated-human-agent-IVR.png" alt-text="Inbound call from customer through Teams":::

Cost calculation:

- One participant on PSTN (inbound from Mae)x 10 minutes x 0.022 per participant per minute = $0.22.
- One participant on Voice over Internet Protocol (VOIP) (inbound to Power Virtual Agents bot) X 2 x $0.004 per minute = $0.008.
  > [!NOTE]
  > The VOIP call to the Power Virtual Agents bot isn't covered by the intelligent voice bot minutes included in the Voice Channel for Dynamics 365 Customer Service license.
- One participant on VOIP (inbound to Matias)x 8 x $0.004 per participant per minute= $0.032.

**Total cost for the call**: $0.22 + $0.008 + $0.032 = $0.26.

## Inbound: A customer calls from Microsoft Teams

Mae calls your Azure Communication Services US toll-free number from Microsoft Teams. The call is routed to Matias and lasts 20 minutes.

:::image type="content" source="media/customer-calls-from-teams.png" alt-text="Diagram illustrating an inbound customer call from Microsoft Teams.":::

Cost calculation:

- One participant on Teams (inbound from Mae) x 20 minutes x rate per minute (Mae's call is covered by the Teams license)
- One participant on PSTN (inbound from Mae) x 20 minutes x $0.022 per minute = $0.44
- One participant on VOIP (inbound to Matias) x 20 minutes x $0.004 per minute = $0.08

**Total cost for the call**: $0.44 + $0.08 = $0.52 + applicable Teams charges

## Inbound: A customer calls from Teams; a supervisor joins the call to monitor the conversation

Mae calls your Azure Communication Services US toll-free number from Teams. The call is routed to Matias, who starts recording it. Gaby, Matias's supervisor, joins to monitor the conversation. The call lasts 10 minutes. The recording stops when the call ends.

:::image type="content" source="media/Customer-calls-Teams-supervisor-joins.png" alt-text="Diagram illustrating an inbound customer call from Microsoft Teams with a supervisor monitoring.":::

Cost calculation:

- One participant on Teams (inbound from Mae) x 10 minutes x rate per minute (Mae's call is covered by the Teams license)
- One participant on PSTN (inbound from Mae) x 10 minutes x $0.022 per minute = $0.22
- One participant on VOIP (inbound to Matias) x 10 minutes x $0.004 per minute = $0.04
- One participant on VOIP (Gaby joins to monitor) x 10 minutes x $0.004 per minute = $0.04 (charged only when Gaby joins the call)
- Cost to record = 10 minutes x $0.002 per minute = $0.02
- Omnichannel for Customer Service recording bot doesn't introduce extra Azure Communication Services VOIP charges.

**Total cost for the call**: $0.22 + $0.04 + $0.04 + $0.02 + applicable Teams charges = $0.32 + applicable Teams charges

## Inbound: A customer calls from a mobile device; the supervisor is invited to consult

Mae calls your Azure Communication Services US toll-free number from Teams. The call is routed to Matias, who starts recording it. Matias invites supervisor Gaby to join in to consult. The call lasts 20 minutes. The recording stops when the call ends.

:::image type="content" source="media/customer-calls-supervisor-consults.png" alt-text="Diagram illustrating an inbound customer call from Microsoft Teams with a supervisor participating.":::

Cost calculation:

- One participant on PSTN (inbound from Mae) x 20 minutes x $0.022 per minute = $0.44
- One participant on VOIP (inbound to Matias) x 20 minutes x $0.004 per minute = $0.08
- One participant on VOIP (Gaby joins to consult) x 10 minutes x $0.004 per minute = $0.04 (charged only when Gaby joins the call)
- Cost to record = 20 minutes x $0.002 per minute = $0.04
- Omnichannel for Customer Service recording bot doesn't introduce extra Azure Communication Services VOIP charges.

**Total cost for the call**: $0.44 + $0.08 + $0.04 + $0.04 = $0.60

## Inbound: A customer calls from Teams; the call is transferred to an agent through Teams PSTN

Mae calls your Azure Communication Services US toll-free number from Microsoft Teams. The call is routed to Matias, who starts recording it. Matias talks to Mae for five minutes and then transfers the call to a product expert, Cole, on Cole's Teams PSTN number. Cole speaks to Mae for another five minutes and ends the call. The recording stops when the call ends.

:::image type="content" source="media/customer-calls-through-pstn.png" alt-text="Diagram illustrating an inbound customer call from Microsoft Teams, routed to another agent through Teams.":::

Cost calculation:

- One participant on Microsoft Teams (inbound from Mae) x 10 minutes x rate per minute (Mae's call is covered by the Teams license)
- One participant on PSTN (inbound from Mae) x 10 minutes x $0.022 per minute = $0.22
- One participant on VOIP (inbound to Matias) x 5 minutes x $0.004 per minute = $0.02
- One participant on PSTN (outbound to Cole) x 5 minutes x $0.013 per minute = $0.065
- One participant on Microsoft Teams (outbound to Cole) x 5 minutes x rate per minute (Cole's call is covered by the Teams license)
- Cost to record = 10 minutes x $0.002 per minute = $0.02
- Omnichannel for Customer Service recording bot doesn't introduce extra Azure Communication Services VOIP charges.

**Total cost for the call**: $0.22 + $0.02 + $0.065 + $0.02 + applicable Teams charges = $0.325 + applicable Teams charges

## Outbound: An agent calls a customer

Matias, the contact center agent, makes an outbound call from Omnichannel for Customer Service to Mae, the customer. Matias talks to Mae for two minutes, then puts the call on hold to consult with supervisor Gaby. Matias talks to Gaby for five minutes, ends the consultation, and resumes the call with Mae. The call lasts another three minutes.

:::image type="content" source="media/agent-calls-customer.png" alt-text="Diagram illustrating an outbound agent call to a customer.":::

Cost calculation:

- One participant on PSTN (outbound from Matias) x 10 minutes x $0.013 per minute = $0.013 (the call continues to be charged when Matias puts it on hold)
- One participant on VOIP (Matias to Azure Communication Services) x 10 minutes x $0.004 per minute = $0.04
- One participant on VOIP (Matias to Gaby) x 5 minutes x $0.004 per minute = $0.02

**Total cost for the call**: $0.13 + $0.04 + $0.02 = $0.19

## Inbound: Azure direct routing

Mae calls your [Azure direct routing](/azure/communication-services/concepts/telephony/telephony-concept#azure-direct-routing) toll-free number from a mobile device. The call is routed to Matias and lasts 10 minutes.

- Matias uses the Omnichannel for Customer Service client application.
- The call goes to a Session Border Controller (SBC) connected through Azure Communication Services direct routing.
- An Omnichannel for Customer Service bot adds Matias to the call by escalating the direct routing call to a group call.

:::image type="content" source="media/direct-routing-outbound.png" alt-text="Diagram illustrating an Azure direct routing inbound call from a customer.":::

Cost calculation

- One participant on PSTN (inbound from Mae) x 10 minutes x rate per the contract with the carrier
- One participant on PSTN (SBC to Azure Communication Services) x 10 minutes x rate per the contract with the carrier
- One participant on Session Initiation Protocol (SBC to Azure Communication Services) x 10 minutes x $0.004 per minute = $0.04 
- One participant on VOIP (inbound to Matias) x 10 minutes x $0.004 per minute = $0.04

**Total cost for the call**: $0.04 + $0.04 + applicable carrier charges = $0.08 + applicable carrier charges

## Outbound: Azure direct routing

Matias makes an outbound call from Omnichannel for Customer Service to Mae through Azure direct routing. The call lasts 10 minutes.

- Matias uses the Omnichannel for Customer Service client application.
- A bot in Omnichannel for Customer Service starts an outgoing call through direct routing.
- The call goes to an SBC connected through Azure Communication Services direct routing.
- The bot in Omnichannel for Customer Service adds Mae to a call by escalating the direct routing call to a group call.

:::image type="content" source="media/direct-routing-inbound.png" alt-text="Diagram illustrating an Azure direct routing outbound call to a customer.":::

Cost calculation:

- One participant on PSTN (outbound from Matias) x 10 minutes x rate per the contract with the carrier
- One participant on PSTN (SBC to Azure Communication Services) x 10 minutes x rate per the contract with the carrier
- One participant on SIP (SBC to Azure Communication Services) x 10 minutes x $0.004 per minute = $0.04
- One participant on VOIP (outbound from Matias) x 10 minutes x $0.004 per minute = $0.04

**Total cost for the call**: $0.04 + $0.04 + applicable carrier charges = $0.08 + applicable carrier charges

## Next steps

[Set up outbound calling in the voice channel](voice-channel-outbound-calling.md)  
[Set up inbound calling in the voice channel](voice-channel-inbound-calling.md)  

[!INCLUDE [footer-include](../includes/footer-banner.md)]

