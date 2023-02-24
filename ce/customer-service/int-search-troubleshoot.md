---
title: Ingestion data isn't updated on Insights tab for integrated search providers
description: Learn how to provision, add, and manage integrated search providers.
author: Soumyasd27
ms.author: sdas
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/24/2023
ms.custom: bap-template
---

# Data doesn't get updated on the Insights tab for integrated search providers

## Symptoms

Data isn't updated on the Insights tab even after the scheduled refresh interval time.

## Resolution

Perform the following troubleshooting steps to diagnose and fix the issue:

- Check if the connection references are set properly in the cloud flow and the flow runs are being triggered at the scheduled Refresh interval period.
- Check whether the root URL or the sitemap URL are configured correctly.
- Check if the **External Reference Id** field is mapped to a unique field in the source property.
- If the source is authenticated, make sure that the secret provided is correct.

If the issue persists, raise a Microsoft support ticket.