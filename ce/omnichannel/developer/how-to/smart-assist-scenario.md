---
title: "Implement a custom scenario for smart assist bot | MicrosoftDocs"
description: ""
author: susikka
ms.author: susikka
manager: shujoshi
ms.date: 02/26/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---
# Implement a custom scenario for smart assist bot

[!INCLUDE[cc-use-with-omnichannel](../../../includes/cc-use-with-omnichannel.md)]

Consider the scenario where a customer who is trying to troubleshoot his printer reaches out to customer support through chat channel. The chat request is accepted by an agent. The customer before initiating the chat browsed through the printer website and the customer support agent can see the articles that the customer has read.

The customer service agent greets the customer with the message `Welcome to Contoso Ltd. I'm happy to assist you today. You were trying to troubleshoot your printer. Is this the same issue?`.

Customer responds with the message `Yes, that is right. My printer is making loud noise. I tried restarting it but that did not help.`.

The customer service agent is presented with a list of knowledge base articles as a recommendation. The agent clicks on the article he finds most relevant and clicks on **Send article** button to send the article to the customer.

## See also

[Build a custom smart assist bot](smart-assist-bot.md)<br />
[Smart assist for agents](../../administrator/smart-assist.md)<br />
[Sample code: Smart Assist for Bots](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/customer-service/omnichannel/smart-assist-bot)