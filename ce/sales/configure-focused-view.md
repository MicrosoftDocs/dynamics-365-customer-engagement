---
title: Configure focused view
description: Save time and improve task organization by enabling and configuring focused view, allowing sellers to easily manage CRM records and associated activities on one page.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: overview
ms.collection:
ms.date: 02/22/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:01/19/2024
---

# Configure focused view

In focused view, sellers can view and manage their CRM records and their associated activities on one page. This view makes it easier for sellers to stay focused on their tasks, saving time by eliminating the need to navigate through multiple screens. It also allows sellers to better organize and prioritize their tasks.

As an administrator, you can do the following configuration for focused view:

- [Enable focused view in your organization](enable-focused-view.md)
- [Configure focused view as default](set-focused-view-as-default.md)

To understand how users can view and manage records in focused view, see [View and manage records in focused view](focused-view.md).

## Permissions required

As an administrator, you must provide the following permissions to users to use focused view.

### View records in focused view

- **Read** permission on the entity for which focused view is enabled.
- Permissions are required for all columns in the view of the entity where the focused view is enabled. More information: [Understand model-driven app views](/power-apps/maker/model-driven-apps/create-edit-views)

### View related activities and sequence steps in focused view

- At least **Read** permission for the activities, including any custom activities.
- Ensure that the sequence related permissions are provided. More information: [Permission requirements to manage sequences](create-manage-sequences.md#permission-requirements-to-manage-sequences)

### Work list card customization

- **Read**, **Write**, and **Append To** permissions to **msdyn_workqueueusersetting** entity.
