---
title: "Overview of Dynamics 365 Productivity Tools | MicrosoftDocs"
description: "Learn about Dynamics 365 Productivity Tools in the Omnichannel Administration app."
author: neeranelli
ms.author: nenellim
manager: shujoshi
ms.date: 09/04/2020
ms.service: 
  - "dynamics-365-customerservice"
ms.topic: article
---

# Productivity tools

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

## Introduction

The Dynamics 365 Productivity Tools app provides capabilities that help users perform day-to-day operations in a fast, efficient, and process-compliant manner and deliver value to customers.


### Challenges

The Dynamics 365 Productivity Tools app contains the following functionality to help with repetitive and monotonous tasks, such as greet customers and fill forms. The tool also helps with displaying AI-based suggestions for knowledge articles and similar cases to agents, and thereby helps users perform day-to-day operations in a fast, efficient, and process-compliant manner.

- [Macros](#macros)
- [Agent scripts](#agent-scripts)
- [Smart assist](#smart-assist)

### Macros

With macros, agents can perform repetitive, monotonous tasks—Open model-driven app forms, pre-populate fields with the details, send an email to a customer, take notes, and much more—all in a single click. A macro is a set of sequential actions that tells the system how to complete a task. When an agent runs a macro, the system performs each action and this helps save time and accommodate agents to handle more customer issues. Also, macros provide preciseness, clarity, and consistency to the tasks that agents perform.

### Agent scripts

Agent scripts provide guidance to agents about what to do when they get a customer issue. The scripts ensure that only accurate, company-endorsed information is being shared, while also safeguarding the organization in regard to legal-compliance issues. Agent scripts help organizations to be unified, accurate, and effective while being quick and  efficient in handling customers.

### Smart assist

Smart assist is an intelligent assistant that provides real-time recommendations to agents, helping them take actions while interacting with customers. It allows organizations to build a custom bot and plug-in real-time to their environment. Also, organizations can develop relevant recommendations such as knowledge articles, similar cases, and next-best steps using Microsoft Adaptive cards. These recommendation cards are displayed on the agent user interface based on the context of the current conversation.

The smart assist feature can be enabled across all channels like Chat for Dynamics 365 Customer Service, SMS, and Facebook, except entity records, making it a consistent experience for agents.

## Agent guidance in productivity pane

The productivity pane, when enabled, displays the agent guidance control that shows the agent scripts and smart-assist cards.

> [!div class='mx-imgBorder']
> ![Productivity pane](../media/productivity-pane-expanded.PNG "Productivity pane in expanded mode")

To learn more, see [Enable the productivity pane to provide guidance to agents](productivity-pane.md).

### Prerequisites
<!--Karthik, are the following prerequisites applicable?-->
- Identify the Common Data Service environment to which you want to deploy Dynamics 365 Productivity Tools. To know the environment details, sign in to Common Data Service platform > **Settings** > **Customizations** and then select **Developer resources**. To learn more, see [Developer resources page](https://docs.microsoft.com/powerapps/developer/common-data-service/view-download-developer-resources).

- Deploy Chat for Dynamics 365 Customer Service in your environment as Dynamics 365 Productivity Tools works only with the Omnichannel for Customer Service app. To learn more, see [Try channels for Dynamics 365 Customer Service](../try-channels.md) and [Configure a chat channel](set-up-chat-widget.md).

### See also

[Macros](macros.md)  
[Agent scripts](agent-scripts.md)  
