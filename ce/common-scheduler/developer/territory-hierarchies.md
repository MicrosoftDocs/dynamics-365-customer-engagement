---
title: Extend Universal Resource Scheduling to filter bookable resources by territory hierarchy
description: Update queries in the schedule board and schedule assistant configuration to use territory hierarchies.
ms.date: 05/06/2024
searchScope: 
  - Field Service
  - Project Service
ms.reviewer: mhart
ms.subservice: common-scheduler
ms.topic: conceptual
author: ryanchen8
ms.author: chenryan
---

# Extend Universal Resource Scheduling to filter bookable resources by territory hierarchy

The article discusses how to extend Universal Resource Scheduling to filter bookable resources and consider the territory hierarchical relationship. As a result when searching with a territory constraint, the system finds bookable resources matching child service territories that relate to the constraint.

## Prerequisites

[Territory hierarchy](../../field-service/set-up-territories.md) must be configured to reflect the organization's service territory setup. 

## Extend the schedule board to filter by territory hierarchy

To filter resources on the schedule board and consider territory hierarchy, you need to update the **Filter layout** and the **Retrieve resources query**.

### Update filter layout

By default, the territory field lets you choose multiple territory values. To consider a hierarchy, the field must accept only one territory.

1. [Open the schedule board settings](../schedule-board-tab-settings.md#board-settings) and go to the **Other** section.

1. In the **Filter layout** section, create a new filter layout and name it.

1. Change the territory field configuration to disallow multiple values:

   `<control type="combo" source="entity" key="Territories" unspecified-key="UnspecifiedTerritory" label-id="ScheduleAssistant.West.Territories" entity="territory" multi="false"  />`

1. Change the filter layout to use the one you created and save your changes.

### Update retrieve resources queries

To get the territory hierarchy and to consider resources from parent or child territories, modify the Retrieve resources query.

1. [Open the schedule board settings](../schedule-board-tab-settings.md#board-settings) and go to the **Other** section.

1. In the **Retrieve resources query** section, create a new query and name it.

1. Insert the following code snippet in the new query definition:

      ```XML
      
      <!-- Territory join --> 

      <link-entity  name="msdyn_resourceterritory" from="msdyn_resource" to="bookableresourceid"  link-type="outer"> 

      <link-entity ufx:if="$input/Territories" name="territory" alias="territory" link-type="inner" to="msdyn_territory" from="territoryid"> 

      <!-- Get the territory name --> 

      <attribute name="name" alias="territoryname" groupby="true" /> 

      <filter> 

          <condition attribute="territoryid" operator="not-null" /> 

      </filter> 

      </link-entity> 

      </link-entity> 

      <!-- Territory filter --> 

      <filter type="or" ufx:if="$input/Territories"> 

          <condition ufx:if="$input/UnspecifiedTerritory[. = 'true']" entityname="territory" attribute="territoryid" operator="null" /> 

          <condition  entityname="territory" attribute="territoryid" operator="eq-or-under"> 

              <ufx:value select="$input/Territories" attribute="value" /> 

          </condition> 

      </filter>
      ```

   Change the directions of the hierarchy relationship by using `eq-or-under` or `eq-or-above` operator in the `<condition  entityname="territory" attribute="territoryid" operator="eq-or-under">` element. It defines if the query looks for resources from parent to child or the other way around.

1. Change the **Retrieve resources query** to use the one you created and save your changes.

## Extend the schedule assistant to filter by territory considering hierarchy

The schedule assistant retrieves the service territory from the requirement. The configuration for the schedule assistant doesn't work on custom tabs or views. 

1. [Open the schedule board settings](../schedule-board-tab-settings.md#board-settings) and go to **Schedule types** > **Work orders**.

1. Select **Edit defaults** to update the schedule assistant configuration. You can reuse the previously created configuration or create new ones in the **Schedule assistant filter layout** and **Schedule assistant retrieve resources query**.  

1. In the **Schedule assistant retrieve constraints query** section, change the territories element from `<Territories ufx:select="lookup-to-list(Requirement/msdyn_territory)" />` to `<Territories ufx:select="Requirement/msdyn_territory"/>`.

1. Make sure to select the updated query and save your changes.

## See also

- [Create territories for accounts, work orders, and resources](../../field-service/set-up-territories.md)
- [Customize the schedule board with a custom resource attribute](../../field-service/extend-schedule-board-custom-resource-attribute.md)
- [Extend Universal Resource Scheduling with Universal FetchXML](universal-fetchxml.md)
