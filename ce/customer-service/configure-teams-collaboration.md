---
title: "Configure Microsoft Teams collaboration | MicrosoftDocs"
description: "Learn how to configure collaboration with Microsoft Teams in Customer Service."
ms.date: 10/04/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
---

# Preview: Configure collaboration with Microsoft Teams

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]

## Introduction

Agents can collaborate with other agents directly through Microsoft Teams to quickly resolve customer issues. As an administrator, you can help agents find the right experts by enabling the collaboration with Microsoft Teams feature.

This feature enables the capability to automatically suggest agents in real time, based on the currently open active case when agents explore contacts in the embedded chat experience.

> [!NOTE]
> In public preview, AI-suggested contacts is available only when users open a case record.


## Regional availability and supported languages

The AI suggestions are supported in the geographical locations that AI Builder supports. More information: [Availability of AI Builder](/ai-builder/availability-region)

The AI suggestions are supported in the following languages:

- English
- Spanish
- Italian
- German
- Dutch
- Japanese


## Enable collaboration with Microsoft Teams

You'll need tenant permissions to enable the enhanced integration with Microsoft Teams feature.

**To enable collaboration with Microsoft Teams and chat**

1. In Customer Service Hub, go to **Service Management**.

2. In the site map, under **Microsoft Teams Integration**, select **Collaboration**.

3. Set the toggle for **Turn on the linking of Dynamics 365 records to Microsoft Teams channels** to **Yes**.

4. Optionally, set the toggle for **Turn on Enhanced Microsoft Teams Integration** to **Yes**. This setting lets agents pin records and views to a Teams channel directly from Dynamics 365 and also suggests agents who worked on similar cases.

5. Optionally, set the toggle for **Enable Confidential Labels** to **Yes** to create private Teams messages and add sensitivity or confidentiality labels in enhanced Microsoft Teams integration.


### See also

[Collaborate with AI-suggested agents in Microsoft Teams chat](use-ai-suggested-agents-teams.md)  
[Overview of Customer Service workspace](csw-overview.md)  

