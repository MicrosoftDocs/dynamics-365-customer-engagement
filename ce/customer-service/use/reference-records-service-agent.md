---
title: Reference records and context in Service Agent prompts
description: Learn how to use "/" to reference cases, contacts, and other Dataverse records directly in your Service Agent prompts.
ms.date: 06/30/2026
author: lalexms
ms.author: laalexan
ms.collection: bap-ai-copilot
ms.topic: how-to
ms.reviewer: laalexan
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Reference records and context in Service Agent prompts

You can include supported records, such as cases, contacts, or files, directly in your Service Agent prompts by using the "/" shortcut. Referencing records gives Service Agent additional context, which helps it generate more accurate and relevant responses based on the records you're working with.

## Prerequisites

- Your administrator must configure Service Agent. Learn more in [Configure Service Agent](../administer/configure-service-agent.md).
- Your administrator must enable the Power Apps record mention feature. Learn more in [Enable Power Apps record mentions](/power-platform/admin/link-records-outlook-web).

If record references aren't enabled, typing / doesn't open the record picker.

## Reference a record in a prompt

1. In the Service Agent message box, type **/** to open the record picker.
1. Start typing the name, number, or keyword for the record you want to reference. Matching results appear, with recently opened records shown first.
1. Select the record you want to include.
1. The record is added to your prompt as a reference. Continue typing the rest of your message.
1. Press **Enter** or select **Send**.

**Example**: `/CAS-01234 Summarize this case and suggest a next best action.

You can also reference multiple records in the same prompt.

**Example**: /CAS-01234 /CAS-04567 Compare these cases and identify common issues.

> [!NOTE]
> When you're already working within a case, Service Agent automatically uses that case as context. Use / only when you want to reference additional records or a different record.

## Supported record types

You can reference the following types of records by using "/":

- Cases
- Contacts
- Files and documents you recently opened

Depending on your organization's configuration, additional Dataverse entity types might be available.

You can only search for and reference records that you have permission to access.

## Tips for using record references

- Use a case number to find a specific case more quickly.
- Include multiple record references in a single prompt when you want to compare records or provide additional context.
- If you're already working within a case, you don't need to reference that case unless you want to reference a different one.

### Related information

- [Use starter prompts in Service Agent](use-service-agent-starter-prompts.md)  
- [Use Service Agent](use-service-agent.md)  
- [Service Agent overview](service-agent-overview.md)  
