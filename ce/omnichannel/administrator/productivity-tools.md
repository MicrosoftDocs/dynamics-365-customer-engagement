---
title: "Overview of Dynamics 365 Productivity Tools | MicrosoftDocs"
description: "Learn about Dynamics 365 Productivity Tools in the Omnichannel Administration app."
author: kabala123
ms.author: kabala
manager: shujoshi
ms.date: 10/25/2019
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Preview: Overview of productivity tools

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

[!include[cc-beta-prerelease-disclaimer](../../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - A preview is a feature that is not complete, as it may employ reduced privacy, security, and/or compliance commitments, but is made available before it is officially released for general availability so customers can get early access and provide feedback. Previews are provided “as-is,” “with all faults,” “as available,” and without warranty.​
> - This preview features does not come with technical support and Microsoft Dynamics 365 Technical Support won’t be able to help you with issues or questions.  If Microsoft does elect to provide any type of support, such support is provided "as is," "with all faults," and without warranty, and may be discontinued at any time.​
> - Previews are not meant for production use, especially to process Personal Data or other data that is subject to heightened compliance requirements, and any use of "live" or production data is at your sole risk.  All previews are subject to separate [Terms and Conditions](../../legal/dynamics-insider-agreement.md).

## Introduction

The Dynamics 365 Productivity Tools app provides capabilities that help users to perform day-to-day operations in a fast, efficient, and process-compliant manner and deliver value to customers. 

### Challenges

In the customer service industry, agents are expected to handle a large volume of customer issues and resolve them at a faster rate with high customer value and satisfaction while adhering to process standards. 

Whilst there are challenges such as:
 
- Too many clicks to perform actions (open a form, fill out the form, save the form, and so on). 
- Repetitive or monotonous tasks (greet a customer, verify a customer, send acknowledgment mail, take notes, and so on).
- Human errors introduced during copy paste of data across different pages 
- Process adherence and compliance that are specific to the contact center business organizations.
- Lack of real-time insights to the customer, knowledge articles, and other relevant needs based on the context of the interaction.

Agents need to tackle these challenges to achieve what their business and customers require. 
 
Dynamics 365 Productivity Tools app helps address these challenges, aiding users to perform day-to-day operations in a fast, efficient, and process-compliant manner.
 
The Dynamics 365 Productivity Tools app contains the following tools:

- [Macros](#macros)
- [Agent scripts](#agent-scripts)
- [Smart assist](#smart-assist)

    > [!div class=mx-imgBorder] 
    > ![Productivity Tools](../media/productivity-tools.png "Productivity Tools")

## Macros

With macros, agents can perform repetitive, monotonous tasks—Open model-driven app forms, pre-populate fields with the details, send an email to a customer, take notes, and much more—all in a single click.
A macro is a set of sequential actions that tells the system how to complete a task. When an agent executes a macro, the system performs each action and this helps save time and accommodate agents to handle more customer issues. Also, macro provides preciseness, clarity and consistency to the tasks that agents perform.
 
## Agent scripts 

Agent scripts provide guidance to agents about what to do when they get a customer issue. The scripts ensure that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help organizations to be unified, accurate, and effective while also being faster and more efficient in terms of customer handling.
 
## Smart assist

Smart assist is an intelligent assistant that provides real-time recommendations to the agents, helping them to take actions while interacting with customers. It allows organizations to build a custom bot and plug-in real-time to their environment. Also, organizations can develop relevant recommendations such as knowledge articles, similar cases, and next-best steps using Microsoft Adaptive cards. These recommendation cards are surfaced to the agent's user interface based on the context of the current conversation.

The smart assist feature can be enabled across all channels like Chat for Dynamics 365 Customer Service, SMS, and Facebook except entity records making it a consistent experience for agents.

## Set up Dynamics 365 Productivity Tools

### Prerequisites 

- Identify the Common Data Service environment to which you want to deploy Dynamics 35 Productivity Tools. To know the environment details, sign in to Common Data Service platform > **Settings** > **Customizations** and then select **Developer resources**. To learn more, see [Developer resources page](https://docs.microsoft.com/powerapps/developer/common-data-service/view-download-developer-resources).

- Get the latest version of Omnichannel for Customer Service (Omnichannel Prime Chat package version 1.5.3.259). Get the trial version from [Dynamics 365 Trials](https://trials.dynamics.com/).

- Obtain global administrator permissions in Office 365 to download and install the Dynamics 365 Productivity Tools (solution).

- Deploy Chat for Dynamics 365 Customer Service in your environment as Dynamics 365 Productivity Tools works only with the Omnichannel for Customer Service app. To learn more, see [Try channels for Dynamics 365 Customer Service](../try-channels.md) and [Configure a chat channel](set-up-chat-widget.md).


### Install Dynamics 365 Productivity Tools package

To set up the Dynamics 365 Productivity Tools, follow the steps. 

1. Go to [Microsoft AppSource](https://appsource.microsoft.com/en-us/product/dynamics-crm/mscrm.d365_productivity_tools-preview?flightCodes=d365productivitytoolspreview). The Dynamics 365 Productivity Tools page appears.

2. Select **GET IT NOW**. 

3. In the **‘One more thing…’** window, select **Continue**. 

4. Read and select the check box to agree to the following: 
    - Microsoft’s Legal Terms and Privacy Statement. 
    - Privacy Statement and Legal Terms for importing the solution into Dynamics 365.

5. Select **Agree**. The Dynamics 365 Productivity tools application (solution) import starts in the background.

    > [!div class=mx-imgBorder] 
    > ![Dynamics 365 Productivity Tools](../media/d365-pt-appsource.png "Dynamics 365 Productivity Tools")

After the installation is successful, you can view the Productivity Tools such as macros and agent scripts in the sitemap of the Omnichannel Administration app.

> [!div class=mx-imgBorder] 
> ![Productivity Tools](../media/pt-sitemap.png "Productivity Tools")

## See also

[Macros](macros.md)

[Agent scripts](agent-scripts.md)

