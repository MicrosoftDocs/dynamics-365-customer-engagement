---
title: "Overview of Dynamics 365 Productivity Tools | MicrosoftDocs"
description: "Learn about Dynamics 365 Productivity Tools in the Omnichannel Administrator app." 
keywords: ""
author: kabala123
ms.author: kabala
manager: shujoshi
applies_to: 
ms.date: 10/25/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: 3CC313DD-919E-443C-888D-6CF69DCC0E07
ms.custom: 
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

## Macros

With macros, agents can perform repetitive, monotonous tasks—Open model-driven app forms, pre-populate fields with the details, send an email to a customer, take notes, and much more—all in a single click.
A macro is a set of instructions that tells the system how to complete a task. When an agent runs a macro, the system performs each instruction and this helps save time and accommodate agents to handle more customer issues. Also, Macros provides preciseness, clarity and consistency to the tasks that agents perform.
 
## Agent scripts 

Agent scripts provide guidance to agents about what they should do when they get a customer issue. It ensures that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help your organization to be unified, accurate, and effective while being faster and more-efficient in terms of customer handling.
 
## Smart assist

Smart assist provides suggestions to agents on what is the next-best course of action they need to take based on the real-time context of the customer interaction. The suggestions are intelligent that are based on the real-time context of the conversation. These suggestions help the  agents to be more productive with knowledge articles, similar cases, and much more. The smart assist is available across all the channels supported by omnichannel making it a consistent and intelligence experience for agents.

## Set up Dynamics 365 Productivity Tools

To set up the Dynamics 365 Productivity Tools, follow the steps. 

### Prerequisites 

- Identify the Common Data Service instance to which you want to deploy Dynamics 35 Productivity Tools. Sign in to Common Data Service platform > **Settings** > **Customizations** and then select **Developer resources**. To learn more, see [Developer resources page](https://docs.microsoft.com/powerapps/developer/common-data-service/view-download-developer-resources).

- Get the latest version of Omnichannel for Customer Service.. Get the trail version from [Dynamics 365 Trails](https://trials.dynamics.com/).

- Obtain global administrator permissions in Office 365 to download and install the Dynamics 365 Productivity Tools (solution).

- Deploy Chat for Dynamics 365 Customer Service in your environment as Dynamics 365 Productivity Tools works only with the Omnichannel for Customer Service app. To learn more, see [Try Chat for Dynamics 365 Customer Service](../try-chat-for-dynamics365.md).


### Install Dynamics 365 Productivity Tools package 

1. Go to Microsoft AppSource. The Dynamics 365 Productivity Tools page appears. 
2. Select **GET IT NOW**. 
3. In the **‘One more thing…’** window, select **Continue**. 
4. Read and select the check box to agree to the following: 
    - Microsoft’s Legal Terms and Privacy Statement. 
    - Privacy Statement and Legal Terms for importing the solution into Dynamics 365. 
5. Select **Agree**. The Dynamics 365 Productivity tools application (solution) import starts in the background. 

After the installation is successful, you can view the Productivity Tools such as macros, agent scripts, and smart assist in the sitemap of the Omnichannel Administrator app.

## See also

[Macros](macros.md)

[Agent scripts](agent-scripts.md)

