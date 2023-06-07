---
title: Troubleshoot issues with integrated search providers
description: Learn how to troubleshoot issues with integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/02/2023
ms.custom: bap-template
---

# Troubleshoot issues with integrated search providers

The article describes troubleshooting steps that you can use to diagnose and fix issues with integrated search providers.

## Data on the Insights tab isn't updated for integrated search providers.

### Symptoms

Data on the **Insights** tab isn't updated, even after the scheduled refresh interval.

### Resolution

Follow these troubleshooting steps to diagnose and fix the issue:

- Make sure that the root URL and the sitemap URL are correctly configured. There might be some misconfiguration, or the URLs that are provided might not exist. Test the URLs in a browser to ensure that they are valid.
- Make sure that the **External Reference Id** field is mapped to a unique field in the source property. Because the ID is expected to be unique, repeated or non-unique fields that are mapped from the source will cause issues when articles are ingested.
- Make sure that you haven't selected **No refresh** in the **Refresh interval** field for a data provider.
- If the source is authenticated, make sure that the correct secret is provided.

If the issue persists, raise a Microsoft Support ticket.

[Learn more about how to manage search providers.](add-search-provider.md#manage-integrated-search-providers)
