---
title: "Set up workstreams and queues for the voice channel | MicrosoftDocs"
description: "Introduction to using Omnichannel for Customer Service."
author: neeranelli
ms.author: daclar
manager: shujoshi
ms.date: 02/28/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# Set up workstreams and queues for the voice channel

Step 3: Set up work stream and queue for voice

A work stream is a collection of routing and work distribution settings. Routing settings define how conversations should be routed to queues. Work distribution settings define how conversations should be allocated to agents within a queue.
Set up a voice work stream
Perform the following steps in the Omnichannel admin center (preview) app to configure a work stream for voice:
1.	On the left pane, select Work streams, and then select Create a work stream.
2.	Enter the following details for the work stream:
a.	Name: An intuitive name, such as Contoso voice work stream.
b.	Work distribution mode: Select Push or Pick.
c.	Type: Select Voice.
Note: By default, Owner and Channel are predefined and unavailable for selection in the private preview release.

 
3.	Select Create. The work stream that you created is displayed.

Configure a voice channel
You can view the list of available phone numbers by selecting Phone numbers (preview) in the left pane. To acquire a new number, you can select Add number on the Phone numbers (preview) page. More information: Acquire a phone number.

To configure the voice channel:
1.	Go to the work stream that you created, and on the page that appears, select Set up voice.
2.	On the Phone number page, select a number from the list, and select Next.
Note: Only those numbers are displayed that have at the least inbound calling enabled and are not already associated with any other work stream. Use the steps in Acquire a phone number if you want to configure a new number.

 
3.	On the Music page, select Next again. In the private preview, the option to select the audio for ring tone is not available.

4.	On the Language page, select Next. In the private preview, only English is supported.
5.	On the Summary page, select Save and close.

 

The phone number is associated with the work stream.



Acquire a phone number
You can acquire additional phone numbers on the Phone numbers (preview) page. The following conditions are applicable:
•	Only three phone numbers are available in one org.
•	Only U.S. numbers, and toll-free numbers.
•	Inbound calling must be enabled on the phone number.
•	If you are adding a number, before you can use it, it must be in the Ready state.
•	Note: If you acquire new numbers in private preview, you will not be charged for the new phone numbers. After preview, you will be charged per phone number. All rates are subject to change.
To acquire a phone number:
1.	Select Add number.

2.	Select Next.
 
3.	On the page that appears, select United States in Country/Region, and Toll free for Number type.
4.	Make sure that you select the options for inbound and outbound.

5.	Select Next.
6.	On the Summary page, review the details and select Purchase phone number. It takes a few
minutes for the new phone number to be added, so don’t close the page right away. After a few seconds, a prompt will appear to indicate that you can either close the page or continue to wait until the purchase information is displayed. At this point, the number provisioning will start and will continue the process even if you close the page.

 
7.	Select Close.


Create queues for voice channels
In Customer Service, work items are assigned to a queue and agent with the help of unified routing. Unified routing is an intelligent, scalable, and enterprise grade routing and assignment capability that can assign the incoming work item to the best suited queue and agent while adhering to work item
requirements and matching them with the agent’s capabilities using round robin routing. For more information on how unified routing works, see Appendix A: Unified routing.

In this section, we’ll cover information on how to create a queue for the voice channel and routing rules to evaluate conditions and assign work items.
Create a queue for the voice channel
In the left pane, select Queues, and then complete the following steps to create a queue for the voice channel:
1.	On the Queues page, select New.
2.	On the Create a queue page, enter a name for the queue.
 
3.	Select Voice for Type and enter a value for Priority as required by your business need.

4.	Select Create. The queue is created and its details are listed.

Assignment rules for a queue
By default, the assignment method for a voice queue is round robin. In the round robin method, work items will be prioritized in the order they enter the queue. Among the agents who match skills, presence, and capacity, work will be assigned to agents in the order they are listed, which means that the agent listed on the top is assigned first.
Configure a routing rule for the work stream for voice
Navigate to the work stream for which you have configured the voice channel and perform the following steps:
1.	In the Routing rules (preview) section, for the Route to queues option, select Create ruleset.
 
2.	Provide a name and description for the ruleset, and then select Create.

3.	On the page that appears, select Create rule.
4.	On the Create rule page, enter a rule name, and in Conditions, define set of conditions using the conversation entity and related entity attributes.
5.	In Route to queue, select the queue that you created and to which the voice call must be routed when the conditions specified are met.

 
6.	Select Create. The rule is created and appears in the list of rules.

7.	Create as many rules as your business requires.
