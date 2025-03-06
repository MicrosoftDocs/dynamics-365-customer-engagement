---
title: Inspections overview (contains video)
description: Learn about inspections in Dynamics 365 Field Service.
ms.date: 08/19/2024
ms.topic: overview
author: josephshum-msft
ms.author: jshum
---

# Inspections overview

Field Service inspections are digital forms that technicians use to quickly and easily answer a list of questions as part of a work order. The list of questions can include safety protocols, pass-and-fail tests for a customer asset, an interview with a customer, or other audits and assessments. You can also [create inspections without a work order](inspections-customer-assets.md).

With a drag-and-drop interface, inspections are easy to create, and much simpler for technicians to fill out compared to paper forms. Inspection answers are [stored in Microsoft Dataverse](./inspections-reporting.md), making it easy to report on results and fit inspections into your automated business processes.

Inspections in Field Service provide:

- **Offline support**: Technicians can view and fill out inspections on their mobile phones or tablets without internet access. Answers are synced when connectivity is restored (cellular or WiFi).
- **Customer assets**: Inspections can be associated with assets, allowing users to see a history of all inspections for a particular piece of equipment.
- **Version management**: Administrators can continuously update and publish inspections to accommodate changing processes and evolving business needs.

## Inspection process

The inspection process involves the following steps:

1. The administrator creates an inspection template and then publishes it, which associates the inspection to a **Service Task Type**.
1. The dispatcher adds the **Service Task Type** to a **Work Order**.
1. The technician completes the inspection.
1. The dispatcher views the inspection results.

For a guided walkthrough, check out the following video.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=cda3ec94-6398-4bb8-aaf6-e2d8906818fb]

## Field Service inspections or work order service tasks

Compared to work order incident types and service tasks, inspections have more benefits:

- **Easier to create**: Administrators can easily create an inspection using the drag-and-drop interface without the need to add new entities and fields.
- **Easier to fill out**: Technicians can quickly enter responses for each inspection question and save them all at once. Work order service task records have to be opened and completed one-by-one.
- **More flexible and robust**: Field Service inspections have many question formats and validation options, such as multi-option select, mandatory fields, images, and attachments.

## Field Service inspections or Power Apps inspections

While you can create inspections in Power Apps, there are a few reasons customers choose to use Field Service inspections.

- **Offline support**: Technicians can view and fill out inspections on their mobile phones or tablets without internet access. Inspections and answers are stored locally on the mobile device and then synced to the server when connectivity is restored (cellular or WiFi).
- **Version management**: Administrators can easily republish or change inspections to accommodate changing processes and evolving business needs.
- **Easier to create and use**: Field Service inspections require no further training and are designed to be easy to use. Power Apps inspections need extensive knowledge of the Power Apps platform and might require coding.
- **More scalable**: If your organization handles many different inspections, it's easier to create Field Service inspections with a drag-and-drop interface and dynamic branching. Power Apps inspections require creating new entities and forms for each inspection, which is more time-consuming.
- **Better integrated with Dynamics 365**: Field Service inspections are built into the work order and asset servicing capabilities.

## Next steps

- [Create and view inspections](inspections.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
