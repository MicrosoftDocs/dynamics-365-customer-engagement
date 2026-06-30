---
title: Upload and analyze files in Service Agent
description: Learn how to use Service Agent with uploaded files as part of the Copilot conversation so that you can get file context without leaving the chat experience.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 06/30/2026
ms.update-cycle: 180-days
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Upload and analyze files in Service Agent

You can upload files to Service Agent and use them as context for your conversation. This lets you ask questions about documents, log files, and other supported files without leaving the conversation.

## Prerequisites

Your administrator must configure Service Agent before you can upload files.

Learn more in [Enable Service Agent](../administer/configure-service-agent.md).

## Upload a file

1. Open Service Agent.
1. Select the attachment or upload button.
1. Select the file that you want to upload.
1. Wait for the file to finish uploading.

The uploaded file becomes part of the current conversation and is available as context for your prompts.

## Ask questions about a file

After uploading a file, enter a prompt about its contents.

**Examples**

- *Summarize this document.*
- *What are the key findings in this report?*
- *Identify any errors in this log file.*
- *List the actions recommended in this document.*

Service Agent analyzes the uploaded file and uses it to generate a response.

## Known considerations

- Uploaded files are available as context only for the current conversation.
- Continue the conversation with follow-up prompts to ask additional questions about the uploaded file.
- Supported file types and size limits depend on how your administrator configured Service Agent.

## Related information

- [Generate images, charts, and files with Service Agent](service-agent-generate-images-charts-files.md)  
- [Use Service Agent](use-service-agent.md)
