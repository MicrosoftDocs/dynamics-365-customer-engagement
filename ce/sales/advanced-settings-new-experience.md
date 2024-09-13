---
title: Advanced settings in the new experience (preview)
description: Learn about advanced settings in the new experience. 
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.topic: conceptual
ms.collection: get-started
ms.date: 09/13/2024
ms.custom: bap-template
---

# Advanced settings in the new experience (preview)

[!INCLUDE [preview-banner-section](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]



The new experience for advanced settings in Dynamics 365 Sales provides a modern, intuitive, and responsive interface that makes it easier to configure and manage your organization's settings. The new experience uses the Unified Interface and replaces the legacy web client experience. Learn more about this change in [Manage Microsoft Dataverse settings](/power-platform/admin/admin-settings).

## Enable the new experience

The new experience is currently in public preview and is available only for orgs that have enabled the **Advanced Settings redirection** feature in the [Power Platform admin center](/power-platform/admin/what-are-preview-features-how-do-i-enable-them#in-the-power-platform-admin-center).

## Legacy web client vs. Unified Interface

The following screenshot shows the advanced settings in the legacy web client experience:

:::image type="content" source="media/legacy-web-client.png" alt-text="Screenshot of the legacy web client for Advanced settings.":::

The following screenshot shows the advanced settings in the Unified Interface:

:::image type="content" source="media/advanced-settings-new-exp.png" alt-text="Screenshot of the Unified Interface for Advanced settings.":::

### Similarities and differences

The advanced settings in the Unified Interface has similar navigation path and functionalities as the legacy web client. However, there are some key differences that you should be aware of.

- Entities are referred to as Tables.
- Customizations are done in Power Apps.
- Navigation paths are similar in most cases, but there are some minor changes as shown in the table below.

| Old navigation                                                                 | New navigation                                                                 |
|-------------------------------------------------------------------------------|-------------------------------------------------------------------------------|
| Customizations > Customize the system > Components > Entities                  | Customizations > Customize the system > Tables                    |
| System > Administration > System Settings                         | System > Administration                       |
| System > Administration > System Settings > Sales             | Moved to **App Settings** page in the Sales Hub app                                    |
| Customizations > Customize the System > Components > Entities > Select entity > Controls tab | Customizations > Customize the system > Tables > Select table > Forms > Select form > Components |