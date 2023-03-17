---
title: "Public IP addresses used for sending e-mails (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how public IP addresses are used for sending e-mails in the real-time marketing area of Dynamics 365 Marketing."
ms.date: 03/17/2023
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Public IP addresses used for sending e-mails

Dynamics 365 Marketing uses a set of dedicated IPv4 public network subnets for sending e-mails. All e-mails sent by Marketing are expected to depart from an IP address belonging to one of the subnets.

Those subnets are owned by the Marketing platform and no other product or customer can use an IP address from them.

> [!NOTE]
> In rare cases (depending on your spam-filter provider) you may need to pre-approve our public IPs in your spam-filter.

To ensure that you always have the current list of IP ranges, you should refer to the [Azure IP Ranges and Service Tags](https://www.microsoft.com/download/details.aspx?id=56519) document. The document is in JSON format and lists all Azure tagged IP subnets. The Service Tag under which the Marketing e-mail public IPs are listed is "Dynamics365ForMarketingEmail". The list of IP subnets is under "addressPrefixes".

This shows your full list of IP ranges used by Dynamics 365 Marketing platform for email sending purposes.

Alternatively, if you need only your Region-specific IP ranges, please refer to the table below:

| D365 Marketing IP range | Geo Code |        Region        |
|:-----------------------:|:--------:|:--------------------:|
|      40.78.242.0/25     |    NAM   |     North America    |
|     13.66.138.128/25    |    NAM   |     North America    |
|      13.71.171.0/24     |    CAN   |        Canada        |
|     191.233.202.0/24    |    SAM   |     South America    |
|      13.75.35.0/24      |    APJ   |     Asia-Pacific     |
|      13.77.51.0/24      |    OCE   |        Oceania       |
|     40.120.64.224/27    |    UAE   | United Arab Emirates |
|     65.52.252.128/27    |    UAE   | United Arab Emirates |
|     104.211.80.0/24     |    IND   |         India        |
|      13.78.107.0/24     |    JPN   |         Japan        |
|     13.69.226.128/25    |    EUR   |        Europe        |
|     13.74.106.128/25    |    EUR   |        Europe        |
|     40.79.138.192/26    |    FRA   |        France        |
|     51.107.129.64/27    |    CHE   |      Switzerland     |
|     51.140.147.0/24     |    GBR   |     Great Britain    |

> [!IMPORTANT]
> In case of emergency we may rotate Geo-based IP addresses. For better reliability and redundancy, we strongly recommend whitelisting all specified IP ranges.