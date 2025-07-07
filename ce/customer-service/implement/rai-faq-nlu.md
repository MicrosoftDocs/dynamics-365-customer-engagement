---
title: Responsible AI FAQs for NLUs in AI agents
description: This FAQ provides information about the  NLUs in AI agents in Dynamics 365 Contact Center and Dynamics 365 Customer Service. 
author: gandhamm
ms.author: mgandham
ms.reviewer: gandhamm
ms.topic: faq
ms.collection: bap-ai-copilot
ms.date: 07/09/2025
ms.custom: 
- bap-template
- responsible-ai-faq
---

# Responsible AI FAQs for NLUs in AI agents

These frequently asked questions (FAQ) describe the AI impact of generative orchestration for agents built in Copilot Studio that are used in Customer Service.

## What is NLU and how is it used in agents?

Natural Language Understanding (NLU) is the foundation for interpreting user statements and converting them into meaningful actions within AI agents. In Microsoft Copilot Studio agents built for Dynamics 365 Contact Center, NLU enables agents to understand intents, extract meaning, and respond appropriately. NLU is essential for both digital and voice interactions, allowing agents to interpret natural human language, identify key information, and deliver relevant responses. By accurately understanding customer needs, NLU-powered agents can provide more intelligent, responsive service experiences that enhance customer satisfaction and streamline interactions across channels. Learn more in [NLU overview](/microsoft-copilot-studio/nlu-overview).

## What NLU options are available in Microsoft Copilot Studio?

Microsoft Copilot Studio offers multiple NLU options to build your agents. You can choose between Generative AI, which moves toward an agentic system, or any of the Classic Orchestrations for more control and fine-tuning. These options can be selected under the Language Understanding section within Copilot Studio.

## How do different NLU options impact my agent's performance?
Each NLU option has different capabilities and limitations that may impact your agent's behavior and performance. Classic Orchestration NLUs use training data provided by customers to create a Dynamic Language Model (DLM) used at runtime. Generative AI NLUs, on the other hand, are pre-trained with Large Language Models (LLMs), which may provide different capabilities and behaviors.

## Where does NLU processing occur for different options?
For Microsoft Copilot Studio NLU, runtime processing happens within Copilot Studio itself. For Microsoft Copilot Studio NLU+, the runtime processing occurs on the Dynamics 365 Contact Center. Understanding where processing occurs can help you make informed decisions about performance and integration requirements.

## What should I consider from a responsible AI perspective when selecting an NLU option?
When selecting an NLU option, it's important to thoroughly review the capabilities and limitations of each option to make an informed decision that best fits your Dynamics 365 Contact Center business needs. Consider factors such as transparency, data privacy, expected performance, and how well the option aligns with your specific use cases and customer expectations.

## How do the underlying technologies differ between NLU options?
Classic Orchestration NLUs rely on customer-provided training data to create Dynamic Language Models (DLMs) that are used at runtime. Generative AI NLUs leverage pre-trained Large Language Models (LLMs), which may offer different capabilities but also different considerations for responsible deployment.

## What transparency considerations should I keep in mind when implementing generative orchestration?

When implementing generative orchestration, it’s important to understand how your chosen [NLU model](/microsoft-copilot-studio/nlu-overview) influences your AI agent’s behavior and performance. Be aware of how the system interprets user inputs, determines actions, and generates responses. Maintaining transparency in these processes helps build trust with your customers and ensures your agent’s actions align with your intended outcomes.

## Related information

[FAQ for using generative orchestration](/microsoft-copilot-studio/faqs-generative-orchestration#what-is-generative-orchestration)  
