---
title: Use trial phone numbers in the voice channel
description: Use this article to understand how you can use trial phone numbers in Dynamics 365.
ms.date: 06/27/2025
ms.custom: bap-template
ms.topic: how-to
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
---

# Use trial phone numbers

[!INCLUDE[cc-feature-availability-embedded-yes](../../includes/cc-feature-availability-embedded-yes.md)]

The voice channel provides up to two trial phone numbers with limited free calling time for your organization. When you run the voice trial for the first time, you're automatically assigned a toll-free trial phone number. The total free calling time for the two trial phone numbers is 60 minutes.

Learn about setting up the trial in [Customer Service trial FAQ](../implement/trial-faq.md) and [Licensing](/dynamics365/contact-center/implement/system-requirements-contact-center).

## How trial phone numbers work

The trial phone number is a toll-free US number and can only be called from within the US. To receive international calls, we recommend that you use a geographic US number as your second trial number. If you're calling the geographic number from outside the US, then international carrier rates apply.

Your voice trial automatically ends after the free calling time elapses. You can also manually end the trial before the free calling time elapses. More information: [End the trial](#end-the-trial)

You can't reuse or purchase the trial phone number. After your free calling time elapses, you can either [purchase new phone numbers](voice-channel-manage-phone-numbers.md) or request Microsoft Support for more calling minutes. 

> [!NOTE]
> You don't need to connect to Azure Communication Services to use trial numbers.
## End the trial

If you want to end the trial before it expires, select **End trial** on the **Phone numbers** page. Then, you can connect to Azure Communication Services using new or existing resources. Learn more in [Connect to Azure Communication Services](voice-channel-acs-resource.md).

> [!IMPORTANT]
> You can't recover trial phone number and any related data after the trial organization expires and is deprovisioned.

## Next steps

[Manage phone numbers](voice-channel-manage-phone-numbers.md)  

### Related information

[Import phone numbers](voice-channel-sync-from-acs.md)  