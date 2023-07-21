---
title: Troubleshoot issues with integrated search providers
description: Learn how to troubleshoot issues with integrated search providers in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 07/03/2023
ms.custom: bap-template
---

# Troubleshoot issues with integrated search providers

The article describes how to diagnose and fix issues with integrated search providers in Customer Service.

## Integrated search provider data on the Insights tab isn't updated after a scheduled refresh

### Issue

The search provider may have been configured incorrectly.

### Resolution

1. Make sure the provider's root URL and sitemap URL are correct. Browse through the URLs to confirm they're valid addresses.

1. Make sure the **External Reference Id** field is mapped to a unique field in the source property. The ID is expected to be unique. Mapping this field to nonunique fields in the source will cause issues when articles are ingested.

1. Make sure you haven't set the **Refresh interval** to **No refresh**.

1. If the source is authenticated, make sure the secret you provided is correct.

If the issue persists, raise a Microsoft Support ticket.

### See also

[Manage integrated search providers](add-search-provider.md#manage-integrated-search-providers)
