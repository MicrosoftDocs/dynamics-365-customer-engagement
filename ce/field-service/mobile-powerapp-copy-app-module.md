---
title: "Make a copy of the "Field Service Mobile" app module | MicrosoftDocs"
description: description
ms.custom:
- dyn365-fieldservice
ms.date: 05/17/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
ms.suite: ""
applies_to:
- "Dynamics 365 (online)"
- "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app:
- D365CE
- D365FS
---

# Make a copy of the "Field Service Mobile" app module
## Prerequisites
> [!Note]
>

>[!TIP] 
> 


> [!div class="mx-imgBorder"]
> ![Screenshot of ](./media/.png)

For a guided walkthrough, check out the following video.

> [!VIDEO 
https://www.microsoft.com/en-us/videoplayer/embed/RWyHY4]

See the video on![Video symbol](../field-service/media/video-icon.png "Video symbol") [Field Service (Dynamics 365) mobile app: Offline JavaScript](https://youtu.be/tUdL5YZA29A) for more details.


## Configuration considerations
## Additional Notes


## Create a custom app module based on "Field Service Mobile"


While we recommend using the standard Field Service Mobile app module, there may be times when an organization will require a second app module or have a custom app module that can be used with the Field Service Mobile application as shown in the image below.

![](media/image6.png)

By leveraging the components and Site Map of the Field Service Mobile app you will have a great starting point from which you can customize your experience.

To create a new Field Service Mobile app module:

1.  In Dynamics 365, navigate to the list of your App Modules and location option to "+ Create New App".

![Graphical user interface  application Description automatically generated](media/image1.png)

2.  From **Create a New App** screen, enter your app name and other optional details. Check option "Use existing solution to create the App" and click "Next".

![Graphical user interface  application  website Description automatically generated](media/image2.png)

3.  The resulting screen allows you to select the solution and site map from which you will create the app module. Select Solution "Field Service" and Site Map "Field Service Mobile" and click "Done.

![Graphical user interface  application Description automatically generated](media/image3.png)

4.  Your new app module will be created with all typical Field Service Mobile components. You can now begin customizing your app module. When ready be sure to Publish the app module.

![Graphical user interface  application Description automatically generated](media/image4.png)

## Make the custom app module available in Field Service Mobile with Offline 

Once the App Module is created, you will need to tag the app module so that it is available to the Field Service Mobile application. To make the app module available to Field Service Mobile:

1.  Associate your app module to a Solution: In Dynamics 365 go to "Settings" then "Solutions" then "New". Enter required details in the resulting screen, then save and close.

2.  After saving you will be back on the Solutions and see your new Solution. Open that solution and scroll down to "Model-driven Apps".

    1.  If you have already created your App Module select "Add Existing" then select your desired app module.

    2.  If you have not yet created the app module you can start creation process by selecting "New".

![Graphical user interface  text  application  email Description automatically generated](media/image5.png)

3.  Once the app is added to the solution, Save and Close the screen. This will add the App Module to the solution you had created.

4.  After adding your add module to a Solution, export the Solution. From the Solutions list, select the solution you had created and "Export" from the command bar. Follow on screen steps to export the Solution package.

5.  Open the exported Solution (.zip) and edit the file "Customizations.xml"

6.  Within Customizations.XML, locate XML node for <AppModule>

7.  Within "< AppModule >", you will insert two nodes for "< appsettings >" as shown below.

    1.  The first is to allow tag the app module for Field Service Mobile application.

        1.  *uniquename* is "ChannelAvailability". the name of your new app module. This follows format of *\[publisher prefix\]\_\[app module unique name\]\_\[app settings unique name\]*. Or "new\_CustomAppModule\_ChannelAvailability" in our example.

        2.  *value* is set to, "FieldServiceMobile".


    2.  The second makes the app eligible to run in Offline First.

        1.  *uniquename* is the name of your new app module. This follows format of*\[publisher prefix\]\_\[app module unique name\]\_\[app settings unique name\]*. Or "new\_CustomAppModule\_ServerMode" in our example.

        2.  *value* is the application, "ServerMode".

                <appsettings>
                <appsetting uniquename="new\_CustomAppModule\_ChannelAvailability">
                <value>FieldServiceMobile</value>
                <iscustomizable>1</iscustomizable>
                <settingdefinitionid>
                <uniquename>ChannelAvailability</uniquename>
                </settingdefinitionid>
                </appsetting>
                
                <appsetting uniquename="new\_CustomAppModule\_ServerMode">
                <value>false</value>
                <iscustomizable>1</iscustomizable>
                <settingdefinitionid>
                <uniquename>ServerMode</uniquename>
                </settingdefinitionid>
                </appsetting>
                </appsettings>

8.  Save the updated XML file and re-add to the .zip file of your solution.

9.  Import the Solution .zip back into your Dynamics organization.

10. After successfully tagging your application for Field Service Mobile, you should now see the app Module in in the app picker screen when after logging into to the application.

![](media/image6.png)

