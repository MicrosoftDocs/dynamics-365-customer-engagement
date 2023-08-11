---
title: Security roles for lead scoring and qualification in real-time marketing
description: Security roles for lead scoring and qualification for real-time marketing in Dynamics 365 Marketing.
ms.date: 08/10/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Security roles for lead scoring and qualification

This article is an overview of security roles related to lead scoring and qualification.

## Understand lead scoring and qualification security roles

To ensure that only appropriate users can create scoring models, Dynamics 365 Marketing provides two security roles: **Lead Score Modeler** and **Lead Score Viewer**.
1. **Lead score viewer**: Provides access to visualize scoring models, yet can't write or modify them.
1. **Lead score modelers**: Provides comprehensive access, including the ability to create, modify, or delete a scoring model.

By default, not everyone in your organization has access to create or visualize scoring models.  If you want to use scoring models, make sure to set up the right permissions using the following documentation:

- [Manage user accounts, user licenses, and security roles](admin-users-licenses-roles.md#inspect-and-customize-security-roles)
