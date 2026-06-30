---
title: Generate images, charts, and files with Service Agent
description: Learn how to use Service Agent in Dynamics 365 Customer Service to generate images and data charts on demand.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 06/30/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Generate images, charts, and files with Service Agent

Service Agent can generate images, charts, and Microsoft Word, Excel, and PowerPoint files directly from natural language prompts. You can create visual content, analyze service data, and generate supporting documents without leaving Copilot Service workspace.

## Prerequisites

Your administrator must configure Service Agent before you can use it. Learn more in [Enable Service Agent in Microsoft 365 Copilot](../administer/configure-service-agent.md).

## Generate an image

Ask Service Agent to create an image based on a description.

**Example prompts**

- *Generate an image showing a network diagram for this issue.*
- *Create an illustration of the steps to reset this device.*
- *Generate a diagram of the escalation workflow.*

Service Agent generates the image and displays it in the conversation. You can continue refining the image by providing additional prompts.

## Generate a chart

Ask Service Agent to create a chart based on service data. This method is useful when you need a quick visualization of case volumes, trends, or other metrics without running a full analytics report.

**Example prompts**

- *Create a bar chart showing open cases by priority.*
- *Generate a chart of case volume for this customer over the past 30 days.*
- *Show me a pie chart of case status distribution for my queue.*

Service Agent generates the chart by using the available data and displays it in the conversation.

## Generate a Microsoft 365 file

Ask Service Agent to generate Microsoft Word, Excel, or PowerPoint files based on your prompt.

**Example prompts**

- *Create a Word document that summarizes this case.*
- *Generate an Excel spreadsheet listing open cases assigned to me.*
- *Create a PowerPoint presentation that summarizes this month's support metrics.*

Service Agent generates the requested file and displays it in the conversation so you can review and download it.

## Tips

- Be specific about the content you want to generate. Include details such as the chart type, document format, or image description whenever possible.
- If the generated content isn't what you expected, continue the conversation with follow-up prompts to refine the result.
- Generated charts use the data available to Service Agent in your current context.

### Related information

- [Upload and analyze files with Service Agent](service-agent-upload-analyze-files.md)  
- [Use Service Agent](use-service-agent.md)
