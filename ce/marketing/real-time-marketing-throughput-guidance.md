---
title: Throughput guidance
description: Guidance for throughput capacity for real-time interactions in Dynamics 365 Marketing.
ms.date: 07/18/2023
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Throughput guidance

In Dynamics 365 Marketing, the [Service limits and fair use policy](fair-use-policy.md) article provides guidance on the scale that the service can support. The interaction limits on the document provide a maximum number of monthly interactions supported by the service today.

The maximum number of interactions per month for you may differ from the service limit. This is governed by the total number of contact packs that you purchase. Details on the purchases of contacts packs can be found on the [pricing page](https://dynamics.microsoft.com/marketing/pricing/). Contact license pack purchases determine the maximum number of Marketing contact records and monthly interactions you can send in a month. More details are provided on the [Quota limits](quota-management.md) page. If your service needs are beyond the maximum capabilities of the service, contact your Microsoft sales team and we can work with you to meet your needs.

The license purchase also determines the number of resources that are dedicated to you, which in turn determines your *throughput*. Throughput is defined as the total number of interactions that you can send per unit of time (second/minute/hour).

The following table provides directional guidance on the throughput you should expect based on the number of monthly contacts quota while your consumption is within that monthly quota. You can increase your monthly quota by upgrading your license with additional contact packs.

| Monthly contact quota     | Throughput (interactions/hr) |
|---------------------------|------------------------------|
| Up to 10,000,000 contacts | 140,000                      |
| 10,000,000+ contacts      | 500,000†                     |

*† Available in Preview. Contact your Microsoft representative if you have or are going to purchase a quota of more than 10,000,000 contacts.*

> [!NOTE]
> The above throughput guidance will vary depending on a few factors such as the complexity of your journey, the number of concurrent journeys that you run, the consumption patterns from other applications that you use, and the resource intensive workloads that are being carried out.

## Throughput example scenario

Let’s look at this with an example. On January 1, Contoso (a coffee maker) purchases 3,000,000 marketing contacts quota. This gives them a throughput of 140,000 interactions/hr. On January 5, they send an email newsletter to a segment of 280,000 customers. Because the maximum throughput for their interaction quota is 140,000 interactions/hr, the newsletter takes about 2 hours to send. On January 10, they run two separate customer journeys targeting 280,000 customers each; one starting 8:00 AM and the other at 9:00 AM. Since they’re able to send 140,000 messages per hour, only half the customers in the first journey receive emails by 9:00 AM.

Between 9:00 AM and 11:00 AM, both journeys start sending emails simultaneously, so each is only able to send roughly 70,000 messages per hour (since the total throughput gets divided between the two journeys). By 11:00 AM, the first journey has completed and the second journey has 140,000 customers left to email. It can now be completed by around 12:00 PM.

## Frequently asked questions

1. **What are the differences between "service limits", "monthly interactions for a customer," and "throughput"?**

    - **Service limits**: This is the absolute high-end limit on what Dynamics 365 Marketing can support. This defines the limits of the product today. Any requirement that a customer has above these limits requires additional work from our end to enable that customer.
    - **Monthly interactions for a customer**: This is the total number of monthly interactions that customers can purchase by buying contacts packs through the [pricing page](https://dynamics.microsoft.com/marketing/pricing/) on the website. This *may* not be the same as the service limits for Dynamics 365 Marketing.
    
        Let’s think about this with an example. Contoso (a coffee maker) purchases 1,000,000 marketing contacts. This entitles them to 10,000,000 monthly interactions. While the product supports 100,000,000 contacts and 300,000,000 interactions, their purchase limits them to the 10,000,000 interaction quota. However, they can buy additional quantities of contacts to increase their quota. They can keep doing so until they hit the service limit. At this point, their purchase entitles them to the service limit of the product. Any further purchases won't give them additional contacts or interactions.
    - **Throughput**: As mentioned above, this is defined as the total number of interactions that you can send per unit of time (second/minute/hour). The throughput is determined by your monthly contact quota.

        Let’s think about this with an example. Contoso has 1,000,000 contacts, which entitles them to a monthly interaction quota of 10,000,000 interactions and a throughput of 140,000 interactions/hr (per the above table). Contoso is preparing a campaign with a single newsletter email targeting 280,000 customers. They can complete this campaign in 2 hours assuming no other campaign is executing simultaneously, because their throughput is 140,000 interactions/hr.

1. **If I upgrade my contact quota between the levels shown in the table above (for example, from 5,000,000 to 10,000,000), will the throughput increase instantly?**

    In the Preview of the higher scale, once you purchase additional contact packs that increase your throughput between levels, we have an SLA of two weeks to ensure that you can see a throughput performance increase.

1. **I do not think that I am getting the throughput that is promised in the tables above. What do I do in that case?**

    If you believe that your throughput doesn't meet expectations as per these guidelines, contact support or [create a ticket](/power-platform/admin/get-help-support).

1. **I have no requirement to purchase contact packs but I would like to increase the throughput on my journeys. Is that possible?**

    You can only increase throughput by purchasing additional contact packs that provide better throughput based on the tiers mentioned in the above table. Reach out to your Microsoft representative to get more help on this.