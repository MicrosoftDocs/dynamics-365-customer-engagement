---
title: "Run the web SDK sample (Dynamics 365 CXP) | Microsoft Docs"
description: "How to run the web SDK sample for Dynamics 365 CXP."
author: alfergus
ms.author: alfergus
manager: shellyha
ms.date: 08/21/2020
ms.service: marketing
ms.topic: conceptual
ms.service: dynamics-365-marketing
robots: noindex,nofollow
---

# Run the web SDK sample for CXP

> [!IMPORTANT]
> This article is pre-release documentation and is subject to change.

## Prerequisites

- [Visual Studio Code](https://code.visualstudio.com/)
- You have the [ingestion key](get-started-websdk.md)

## Run sample

1. [Download the Product Insights web SDK sample](https://download.microsoft.com/download/f/e/c/fec76936-6440-414d-b75a-7be644f82892/pi_websdk_sample.zip).
2. [Install the Live Server extension](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer) in Visual Studio Code.
3. Unzip the compressed file `pi_websdk_sample.zip`.
4. Open the unzipped folder in Visual Studio Code.
5. In the `pi_websdk_sample.html` file, replace the string “INGESTION_KEY” with your ingestion key from the Product Insights portal, and the string “NAME” with the global name that you want the SDK to be instantiated in. Be sure to replace all occurrences.
6. Open the `pi_websdk_sample.html` file using Live Server in Visual Studio Code.