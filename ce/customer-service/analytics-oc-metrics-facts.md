---
title: FactConversation
description: Learn about the out-of-box Omnichannel historical and real-time analytics metrics facts tables.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: conceptual 
ms.date: 04/11/2023
ms.custom: bap-template
---

# FactConversation

In Dynamics 365 Customer Service, a conversation represents the entire end-to-end interaction with a customer. A conversation is an equivalent of a customer request that reached one of your omnichannel channels like voice, messaging, or chat. A conversation is created when the request is received by Dynamics 365 Customer Service. A conversation can have one or more session. A session is created whenever the system looks to identify an agent to be assigned to work on the conversation.  

If you consider this flow representing a single conversation, you will see that multiple sessions have been created, the first session is created after conversation is created and is assigned to a bot. The second session is created after the bot escalates the conversation to human agent. The first session is closed, and the second session is created to identify the best agent to work on the customer request. After the best agent is identified, the agent is assigned to the conversation to work on it. When the agent chose to reject the request, a new session is created and the process of identifying another agent is started.  

## Abandoned conversation

Abandoned rate refers to the percentage of incoming conversation requests that are ended before customers can be connected to a human agent from the customer service team. Abandoned conversations lead to customer frustration as they didn’t get any assistance from the contact center. A conversation can be abandoned for multiple reasons - like customer leaving due to long wait times or getting disconnected, force closure of request by supervisors, automatic system actions configured to respond to handle overflow etc. A higher abandoned rate can result in decreased customer satisfaction and may need further investigations into operational metrics like agent availability, queue distribution etc.  

If Bot/IVR handles the customer before escalating, it to human agent - This metric is calculated as count of conversations that were abandoned while waiting for a human agent after escalation from bot. If the conversation is abandoned before a bot can be assigned, the conversation is considered abandoned.

Customers reach human agent queue directly- This metric is calculated as count of incoming conversations that were abandoned.  

The conversation direction is Incoming. Channels through which the conversation came in are Messaging and Voice. 

### Related metric

Abandoned rate refers to percentage of incoming conversation requests that are ended before customers can be connected to a human agent. This metric is calculated as count of abandoned conversations divided by count of bot escalated conversation.

## Active conversations awaiting agent acceptance

Active conversations awaiting agent acceptance is the count of conversations requests from customers that have been assigned an agent to assist them and are currently waiting for the agent to accept the request and join the conversation. 
These conversations will go back to being an Open conversation if the agent chooses to reject the request or if they respond to the request.

## Active conversations with agent acceptance

Active conversations with agent acceptance is the count of conversations that have an agent joined and in active contact with customer. Supervisors can monitor these conversations, and track sentiment to ensure customer satisfaction and intervene if needed.

## Conversation first wait time (sec) 

Conversation first wait time is a measure of how long customers had to wait before the customer service team can respond to a customer's request. It represents the time spent by a customer waiting to get the first contact from a human agent from the contact center. Agent availability, high volume of requests, increased handle time could be some of the reasons that can influence customer wait times. Lower wait times, in turn indicates that customers can get their issues resolved faster and can have a better support experience.  

If Bot/IVR handles the customer before escalating, it to human agent – The calculation for this metric is based on the amount of time that passes between the moment a bot escalates an incoming conversation to human agents and the moment an agent accepts the conversation. If the customer ends up abandoning the conversation, the calculation is based on the amount of time between when the bot passes the conversation to the human representative and when the customer disconnects. 

If customer reaches human agent queue directly - The calculation for this metric is based on the amount of time that passes between the moment a customer creates the request and the moment an agent accepts the conversation. If the customer ends up abandoning the conversation, the calculation is based on the amount of time between when the customer creates the request to the human representative and when the customer disconnects.

This metric is available in two formats - seconds and in hh:mm:ss

### Related metric

- Avg. conversation first wait time – Metric is calculated by taking the total waiting time that for customers wait in the queue, and then dividing it by the total number of customers who are were served. 
- Longest wait time – Measured as wait time of conversation with longest first wait time amongst incoming conversation that is yet to be accepted by an agent.
- Conversations in queue – This metric is measured as count of customer request that are currently awaiting agents to be assigned or conversations that have been assigned an agent, and are waiting for the agent to accept the request. 
- Avg. wait time
- Wait time  
 
For metrics around how much time customers wait in individual queues, if they get transferred from one to another refer to <session wait time> 

## Average speed to answer 
 
Average speed to answer (ASA) is a measure of how quickly the customer service team can respond to a customer's request. It is calculated by taking the total waiting time that for customers wait in the queue, after being escalated from the bot to get support from a human agent, and then dividing it by the total number of customers who are were served. Average speed to answer reflects the efficiency and availability of the agents. A lower ASA indicates that customers can get their issues resolved faster and have better experience with the service.  

If Bot/IVR handles the customer before escalating it to human agent - Speed to answer is calculated from time bot escalates the incoming conversation to human agent till it gets accepted by a human agent. 

If Customer reaches human agent queue directly - Speed to answer is calculated from the time customer request created till it gets accepted by a human agent. 
 
This metric is available in two formats - seconds and in hh:mm:ss.

### Related metric

Service level 

- Service level (10 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 10 seconds.
- Service level (20 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 20 seconds. 
- Service level (30 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 30 seconds. 
- Service level (40 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 40 seconds. 
- Service level (60 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 60 seconds. 
- Service level (120 seconds) – This metric is measured as percentage of customer conversation requests with speed to answer less than 120 seconds. 

For metrics around how soon, an agent accepts a request, refer to speed to answer. 

## Conversation handle time  
 
Conversation handle time is time spent by human agents from contact center actively assisting the customers they are assigned to work with, in addressing their issue. If multiple agents handled the conversation, then time spent by all the agents is aggregated. Time spent by agents wrapping up the conversation, after the customer disconnects, performing actions like updating notes or contact details etc. is also included in the handle time. Time spent by SMEs or other agents consulting with agents assigned to work on customer conversation in not included in this metric.  
 
An agent is considered actively working on the conversation if they have the conversation open and in focus within the Customer Service Workspace application.  

If AHT is consistently high, it could be an indication that agents are taking too long to resolve customer issues, that agents need more training or support to help them work more efficiently etc. High AHT can also indicate a problem with customer satisfaction, as it may suggest that customers are not receiving the level of service or support, they need to resolve issues more quickly. 

To understand time spent by individual agents, in case of conversations handled by multiple agents refer to <session handle time metric>  

This metric can be viewed in two formats - seconds and in hh:mm:ss.  
 
The conversation direction is Incoming and Outgoing. Channels through which the conversation came in are Messaging and Voice. 

### Related metric  

Average handle time: This metric is calculated by taking the total handle time of all customer request, and then dividing it by the total number of customers who are were served. 

## Avg. conversation hold time (sec)

This metric represents the average duration the customer was put on hold by human agents handling the conversation. If the conversation was handled by multiple agents, conversation hold time is calculated as sum of hold time across all agents handling this conversation. This metric is calculated by taking the total hold time of all customer requests, and then dividing it by the total number of customers who are were served. There are several reasons why an agent might put a customer on hold during like gathering additional information or research an issue, performing tasks that don’t require interaction like entering data into a system or performing an offline task etc. A higher hold time may cause customer frustrations and may lead to poor customer experience.    
 
## Avg. conversation talk time (sec) 

This metric represents the average time spent by human agent actively conversing with customers on the phone for voice conversation. If a conversation was handled by multiple agents, conversation talk time is aggregated across all agents. This metric is calculated by taking the total hold time of all customer request, and then dividing it by the total number of customers who are were served. 

### Related metric  

Conversation Talk Time: This metric is calculated by taking total talk time across all customer requests  

## Avg. conversation time (sec) 

This metric represents the average time a customer spent with the contact center while seeking assistance from the contact center. It includes time spent waiting for agents to work with them.  

### Related metric 

Conv. Time: This metric is calculated as time difference between when the customer initiated the request and the time the agent wrapped the conversation. Time spent by agents with bot is also included.

## Avg. conversation wrap up time

This metric represents the average time agents spend after the customer leaves to complete any necessary tasks, such as documenting the conversations, updating notes, or updating the customer’s information etc.  It is calculated as the time difference between the time wrap-up was initiated and the time the conversation was closed by the agent. If multiple agents handled a conversation, it applies only to the time spent by the agent who is last to work with the customer.   

This metric can be viewed in two formats - seconds and in hh:mm:ss".

## Waiting conversations 
 
This metric is a count of conversations currently in a waiting state. A conversation gets transitioned to waiting when you (agent) close the session without ending the conversation (that is, without selecting the End button on the communication panel) or when the customer closes the browser window without closing the chat widget. In case of asynchronous messaging channels, it refers to the conversations that waiting for agent to respond. Refer to Understand conversation states | Microsoft Learn  

## Wrap-up conversations 
This metric is a count of conversations currently in a wrap-up state. A conversation is in wrapping-up state when the agent ends the conversation, or when customer leaves the conversation by ending the conversation on their side or gets disconnected. Refer to Understand conversation states | Microsoft Learn 

## Total conversations 

Total count of customer conversation  . Refer to Understand conversation states | Microsoft Learn 

## Incoming conversation 

Total count of conversations requests that were received by contact center and initiated by customers across all channels. Refer to Understand conversation states | Microsoft Learn 

## Sentiment  
This metric represents the current sentiment of customer.  This is powered by Omnichannel for Customer Service sentiment analysis.  
 
## Subject  
This metric represents title of the conversation.

## Conversation id  
This represents reference id of the conversation. This metric can be used for associating conversations, with the sessions handled  
 
## Created on 
This represents the time customer conversation request was created. In case of incoming conversation, it is calculated as the time customer stared the request. In case of outgoing conversation, it is calculated.

## Next steps

[Understand out-of-the-box data model](customize-reports.md#understand-out-of-the-box-data-model)  
[Customize visual display](customize-reports.md#customize-visual-display-of-historical-analytics-reports-in-customer-service)


<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
