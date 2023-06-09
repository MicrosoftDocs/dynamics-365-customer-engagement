---
title: Customization considerations for the work order form
description: 
ms.date: 06/09/2023
ms.topic: conceptual
author: lmasieri
ms.author: lmasieri
ms.custom: bap-template
---

# Customization considerations for the work order form

This article lists common considerations when customizing the work order form.

## Open work order subgrids as popups

Configure work order subentities to pop out as dialog boxes and edit them without having to leave the work order form. This configuration helps dispatchers keep the work order context. Administrators can enable the **Work Order Subgrid Records Open as Popups** setting in the settings area. For more information, go to [Other settings](configure-default-settings.md#other-settings).

## Show simplified work order commands

The work order ribbon uses the simplified view by default. It shows only the most relevant commands. An administrator can disable the **Show Simplified Work Order Commands** setting to show all commands. For more information, go to [Work Order / Booking settings](configure-default-settings.md#work-order--booking-settings).

Check out the following video on simplified work order commands and more updates to work orders.

## Custom work order statuses

Work order system statuses should *never* be edited because system jobs and plug-ins rely on these statuses. Instead, administrators can create custom work order substatuses that map to work order system statuses.

## Add Bing Maps to the work order form

If the Bing Maps control is manually removed from the out-of-the-box work order form, it can't be added back.

To enable Bing Maps button in form designer, at least one of the attributes of type address should have the mask *ValidForMap* added in the form.

Below is the XML for the account form where we see *ValidForMap* added to its address attribute.

```xml
<DisplayMask>ValidForAdvancedFind\|ValidForForm\|ValidForGrid\|ValidForMap</DisplayMask>
```

1. Create a solution on a sandbox environment that includes the form to which the Bing Maps control needs to be added. Export it as managed solution.

1. In the solution's `customizations.xml` file, go the `formxml` part of it.

1. Add the following maps control to the `<controlDescriptions>`.

```xml
        <controlDescription forControl="{8b67ae03-1701-54d2-09be-35295876ca8a}">

        <customControl id="{4273EDBD-AC1D-40d3-9FB2-095C621B552D}">

        <parameters>

        <datafieldname>msdyn\_mapcontrol</datafieldname>

        </parameters>

        </customControl>

        <customControl formFactor="0" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        <customControl formFactor="1" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        <customControl formFactor="2" name="MscrmControls.Map.MapControl">

        <parameters>

        <value>msdyn\_mapcontrol</value>

        <mapSourceSwitch isGroup="true" static="true">CoordinatesGroup</mapSourceSwitch>

        <latitude>msdyn\_latitude</latitude>

        <longitude>msdyn\_longitude</longitude>

        <addressEditableSwitch isGroup="true" static="true">isAddressEditableYesGroup</addressEditableSwitch>

        <outputLatitude>msdyn\_latitude</outputLatitude>

        <outputLongitude>msdyn\_longitude</outputLongitude>

        </parameters>

        </customControl>

        </controlDescription>

```

1. Search for "Bing Maps" in the same file.

1. Add the control with the following code to the row and cell wherever it needs to be added.

```xml
    <control disabled="false" id="msdyn\_mapcontrol" classid="{F9A8A302-114E-466A-B582-6771B2AE0D92}" uniqueid="{8b67ae03-1701-54d2-09be-35295876ca8a}" datafieldname="msdyn\_mapcontrol"/>
```

1. Save the file and create a new managed solution zip file out of it.

1. Import the solution to the affected environment.

> [!TIP]
> If the map control is still not visible on the form after following these steps, try removing the active form customizations.

## Next steps

- [Set up booking statuses](set-up-booking-statuses.md)
- [Create a work order](create-work-order.md)

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RWP4vU]
