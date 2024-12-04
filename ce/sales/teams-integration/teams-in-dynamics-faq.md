---
title: Microsoft Teams chat integration FAQs
description: Collaborate efficiently in Dynamics 365 without switching to Teams. This page includes FAQs about the integration.
ms.date: 07/26/2023
ms.topic: article
author: sbmjais
ms.author: shjais
ms.reviewer: shjais 
---

# Microsoft Teams chat integration FAQs

## Will the integration in any way affect security constraints or configuration in Dynamics 365 and Teams?  

No. The integration is developed with the core principle of not violating security in any direction. Connecting a chat or channel doesn't automatically grant participants of those chats or channels access to that Dynamics record. Dynamics security roles & permissions supersede any membership of a connected chat or channel. Similarly, the user trying to create a team or channel from the **Collaborate** experience in Dynamics 365 must have Teams permissions to do so.

## Is the Teams conversation data stored in Dynamics 365?

Only the conversation ID is stored in Dynamics 365, by using a link entity to make the connection between the record and the conversation. No conversation text is stored in Dynamics 365.

## Is Teams chat integration supported on mobile devices?

No, Teams chat integration isn't supported on mobile devices.
