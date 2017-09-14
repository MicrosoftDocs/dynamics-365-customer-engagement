---
title: "Main forms in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"  
ms.assetid: da3ac59a-5413-46cb-b355-1987e42e3853
caps.latest.revision: 35
ms.author: "rdubois"
manager: "brycho"
---
# How main forms are presented in different clients
The main form is used by every client. This form provides a consistent user experience whether someone is using the web application,  [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)], [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)], or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)].  
  
<a name="BKMK_MainFormPresentations"></a>   
## Main forms  
 Any main forms that exist for an entity may be displayed differently depending on the factors in the following table below. When you design a main form, consider how it works in each different presentation.  
  
|Presentation|Description|  
|------------------|-----------------|  
|**Updated**|For the [Updated entities](../customize/create-design-forms.md#BKMK_UpdatedEntities) and any custom entities, the updated form provides a new user experience in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)]. These forms have the new command bar design, and enable additional features such as the command bar, auto-save, and business process flows.|  
|**Dynamics 365 for tablets**|[!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] presents the content of the main form in a manner optimized for a tablet.|  
|**Dynamics 365 for phones**|[!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] presents the content of the main form in a manner optimized for a phone.|  
|**Classic**|These forms are for the entities that haven't been updated. They use the ribbon rather than the command bar and the navigation pane on the left side of the form.<br /><br /> These forms have a two-column layout.|  
|**Dynamics 365 for Outlook reading pane**|[!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] presents a read-only view of records in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)]. This presentation doesn’t support form scripts.|  
  
<a name="BKMK_MainFormComponentsForUpdatedEntities"></a>   
## Updated forms  
 This diagram represents common components found in updated entity forms.  
  
 ![Diagram shows Updated entity form structure in Dynamics 365](../customize/media/updated-form-diagram.png "Diagram shows Updated entity form structure in Dynamics 365")  
  
 For updated entities, the layout of the form works with a wide range of displays and window sizes. As the width of window decreases, tab columns move down so that you can scroll down to work with them instead of being compressed or requiring you to scroll to the right.  
  
 The following table summarizes available components of the main form for updated entities.  
  
|Component|Summary|  
|---------------|-------------|  
|**Navigation bar**|Uses the data in the site map to provide the ability to move to different areas of the application.<br /><br /> The navigation pane used in classic forms isn’t included in the updated form. In the context of a record, the navigation bar provides access to views of related records. Rather than navigating to related records using the navigation pane or by using the navigation bar, adding sub-grids configured to show useful related entity records provides a better experience for most people.|  
|**Command bar**|Uses the data defined for ribbons to provide commands relevant for the record.<br /><br /> The first five commands are displayed followed by an ellipsis (![More commands button](../customize/media/not-available.gif "More commands button")) that provides a flyout menu to choose additional commands.|  
|**Image**|When an entity has an image field and the entity **Primary Image** option is set to **Default Image**, an image can be displayed in the header when the form is configured to show the image. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Enable or disable options](../customize/create-edit-entities.md#BKMK_EnableDisableOptions), [Image fields](../customize/create-edit-fields.md#BKMK_ImageFields) and [Form properties](../customize/use-the-form-editor.md#BKMK_FormProperties)|  
|**Header**|Fields placed in the header remain visible when people scroll down through the body of the form.<br /><br /> Up to four fields can be placed in the header. Multiple lines of text, web resources, or IFRAMEs aren’t allowed in the header. The header and footer share some properties with sections. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/use-the-form-editor.md#BKMK_SectionProperties)|  
|**Process Control**|When an entity has active business process flows, the process control displays below the header. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Business process flows](../customize/business-process-flows.md)|  
|**Body**|The body is the scrollable part of the form that contains the tabs.|  
|**Tabs**|In the body of the form, tabs provide horizontal separation. Tabs have a label that can be displayed. If the label is displayed, tabs can be expanded or collapsed to show or hide their content by clicking the label.<br /><br /> Tabs contain up to three columns and the width of each column can be set to a percentage of the total width. When you create a new tab, each column is prepopulated with a section. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tab properties](../customize/use-the-form-editor.md#BKMK_TabProperties)|  
|**Sections**|A section occupies the space available in a tab column. Sections have a label that can be displayed and a line may be shown below the label.<br /><br /> Sections can have up to four columns and include options for displaying how labels for fields in the section are displayed. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/use-the-form-editor.md#BKMK_SectionProperties)|  
|**Fields**|Fields display controls people use to view or edit data in an entity record. Fields can be formatted to occupy up to four columns within a section. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Common field properties](../customize/use-the-form-editor.md#BKMK_FieldProperties)|  
|**Spacer**|A spacer allows for an empty space to be added to a section column.|  
|**Sub-grids**|Sub-grids allow for the display of a list within the form. The ability to display charts using a sub-grid isn’t available in forms for updated entities.|  
|**Quick View Form**|A quick view form displays data from a record referenced by a lookup field on the form. The entity that is the target of the lookup must have a quick view form before one can be added to the form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Create and edit quick view forms](../customize/create-edit-quick-view-forms.md)|  
|**Web Resources**|HTML and [!INCLUDE[pn_MS_Silverlight_full](../includes/pn-ms-silverlight-full.md)] web resources can be added to main forms but they won’t be displayed when using [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets or the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] reading pane.|  
|**IFRAME**|An inline-frame that you configure to show a webpage from another website. **Important:**  <ul><li>When the page displayed in an IFRAME is on another domain, browsers apply a higher level of security. This may complicate the requirements for the contents of an IFRAME to interact with data in the form.</li><li>IFRAMEs aren’t displayed when using the [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] reading pane.</li><li>Displaying an entity form within an IFRAME embedded in another entity form is not supported. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [SDK: Supported extensions for Dynamics 365](https://msdn.microsoft.com/library/gg328350.aspx)</li></ul>|  
|**Bing Maps**|When this control is present in a form for an updated entity and the system setting **Enable Bing Maps** is enabled with a valid Bing Maps key, this control can be used one time in a form to show the location for one of the addresses in an updated entity. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configuring Bing maps](../customize/use-the-form-editor.md#BKMK_BingMaps)|  
|**Footer**|Any number of fields, web resources, or IFRAMES can be added to the footer. Fields are read-only when displayed in the footer. The header and footer share some properties with sections. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Section properties](../customize/use-the-form-editor.md#BKMK_SectionProperties)|  
|**Status Bar**|The status bar displays the status field for the record, a notification area, and a save button.|  
  
<a name="BKMK_CRMforTabletsPresentation"></a>   
## Dynamics 365 for phones and tablets forms  
 Most system entities and custom entities are available for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets. The main form for these entities is transformed to a presentation optimized for phones or tablets.  
  
<a name="BKMK_EntitiesEnabledForCRMForTablets"></a>   
### Entities enabled for Dynamics 365 for phones and tablets  
 Only entities that are enabled for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets use this presentation of the main form. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Entities displayed in Dynamics 365 for phones and tablets](../mobile-app/customize-phones-tablets.md#BKMK_CustomEntity)  
  
### Form design  
 [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets takes many of the main form elements and presents them in a way optimized for phones or tablets. The following diagrams show the reflow from the web app to the tablet and phone apps.  
  
 **Web app**  
  
 ![Dynamics 365 form reflow from web app](../customize/media/custon-reflow-web-app.png "Dynamics 365 form reflow from web app")  
  
 **Tablet app**  
  
 ![Dynamics 365 form reflow to tablet app](../customize/media/reflow-tablet-app.png "Dynamics 365 form reflow to tablet app")  
  
 **Phone app**  
  
 ![Dynamics 365 form reflow to phone app](../customize/media/custon-reflow-phone-app.png "Dynamics 365 form reflow to phone app")  
  
 The form elements are transformed to a wide panorama layout in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], where users swipe the screen to change elements visible within a view port. In [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], users swipe the screen to see a different column, or pane of elements, and the process control appears over every column.  
  
### View port element  
 The following items are always visible within the view port in the context of a form:  
  
 **Nav bar**  
 The nav bar is a presentation of the sitemap that is optimized for touch. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change navigation options](../mobile-app/customize-phones-tablets.md#BKMK_NavigationOptions)  
  
 **Home**  
 The home button takes users to the dashboard that is the starting page for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets.  
  
 **Process Control**  
 If the entity has a business process enabled, it will appear in the top right corner next to the search control in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], and at the top of the screen in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)].  
  
 **Search**  
 People can tap the search control to open the screen to search for records.  
  
 **Command Bar**  
 By default, some of the commands that appear in the web application do not appear in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets apps. Similar to the web application, the command bar is context-sensitive, so the available commands change depending on what is currently viewed or selected. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Change commands](../mobile-app/customize-phones-tablets.md#BKMK_ChangeCommands)  
  
### Form elements  
 The form elements displayed are taken from the main form and presented as a series of panels that users see through the view port.  
  
 In [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], the first panel displays contact information about relationships that exist for the record. In [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], the first panel also displays header fields from the form above the relationship tiles.  
  
 ![Dynamics 365 for tablets relationships panel](../customize/media/mobile-app-form-relationships.png "Dynamics 365 for tablets relationships panel")  
  
 For Contact and User forms, the top item displays a communication card for the record. The communication card provides buttons to initiate communication with the person. For other entities, a communication card is displayed if there is a Contact quick view form embedded in the main form.  
  
 You can show additional tiles based on entity relationships, but you can’t customize the tiles for the following entities:  
  
|Entity|Tiles|  
|------------|-----------|  
|Account|Owner|  
|Contact|Company Name, Owner|  
|Lead|Owner|  
|Opportunity|Account, Owner|  
  
 You can customize the remaining tiles with the form editor. The order is fixed, but you can set which elements are visible in the relationship panel.  
  
 In [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)], the second panel begins with the name of the first tab on the form. Any fields that are included within the header are included and then the contents of the first tab. In [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], headers appear in the first column.  
  
 ![CRM for Tablets Form First Panel](../customize/media/mobile-app-form-first-panel.png "CRM for Tablets Form First Panel")  
  
 If there is a process flow active for the form, the third tab displays tasks for the current stage of the process in [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)]. In [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)], the process control floats above the panes, expands over the user’s current pane when it’s selected, and is always visible and actionable.  
  
 The remaining panels of the form contain the contents of the tabs in the form. Any subgrids found display as a separate panel.  
  
 The [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets form always displays the labels for tabs and sub-grids. The **Display Label on the Form** setting is not applied.  
  
> [!NOTE]
>  To optimize performance on mobile devices, the number of objects is limited to 5 tabs or 75 fields and 10 subgrids.  
  
 Forms for [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets don’t support the following:  
   
-   Bing maps  
  
- [!INCLUDE[pn_yammer](../includes/pn-yammer.md)]  
  
-   Activity feeds  
  
-   Theming  
  
 In addition, entity images are visible in list views and contact cards, but not within the actual form.  
  
<a name="BKMK_MultipleForms"></a>   
### Multiple forms  
 [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] for phones and tablets supports multiple forms but doesn't provide a way for people to switch between forms if they can access more than one. People will see the first form in the form order that they have access to.  
  
 For example, if you have the following main forms for the opportunity entity and have assigned the following security roles for each one, you’ll see the form order shown in the following table.  
  
|Form Order|Form Name|Security roles|  
|----------------|---------------|--------------------|  
|1|**Sales Form One**|Salesperson|  
|2|**Sales Form Two**|Salesperson and Sales Manager|  
|3|**Sales Form Three**|Sales Manager|  
|4|**Sales Form Four**|Vice President of Sales|  
  
-   People with the Salesperson role will always see **Sales Form One**.  
  
-   People with the Sales Manager role will always see **Sales Form Two**.  
  
-   People with the Vice President of Sales role will always see **Sales Form Four**.  
  
<a name="BKMK_ClassicPresentation"></a>   
## Classic forms  
 The following diagram shows the main form components used in the classic presentation.  
  
> [!NOTE]
>  When an organization upgrades from [!INCLUDE[pn_CRM_2011](../includes/pn-crm-2011.md)] or an earlier version of CRM Online, their forms were designed to use the classic presentation. For information about how to migrate these forms for updated entities, see [Merge forms to use new layout](../customize/update-forms.md).  
  
 ![Major form elements](../customize/media/elements.png "Major form elements")  
  
 The forms for updated entities have inherited many components from the classic forms, but there are significant differences.  
  
 Forms using the classic presentation don’t include the navigation bar and the ribbon is used instead of the command bar. These forms don’t support entity images, the process control, quick view forms, auto-save, or Bing Maps. Fields in the header aren’t editable.  
  
 The form assistant is exposed for certain entities, such as `Article`.  
  
<a name="BKMK_ReadingPane"></a>   
## Dynamics 365 for Outlook reading pane  
 People using [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to view records can access a read-only view of the record using the reading pane as shown here.  
  
 ![Outlook reading pane in Dynamics 365 2013 for Outlook](../customize/media/outlook-reading-pane.PNG "Outlook reading pane in Dynamics 365 2013 for Outlook")  
  
 The reading pane uses the main form and displays just the sections within each tab. Form scripts aren’t loaded. Process controls, Bing Maps, web resources, quick view forms, footer fields, and IFRAMEs aren’t displayed. The notes control displays only notes, not posts or activities. Like [Dynamics 365 for tablets forms](../customize/main-form-presentations.md#BKMK_CRMforTabletsPresentation), the reading pane supports multiple forms but people can’t switch forms. The form used is the first form that the person has access to. For an example, see [Multiple forms](../customize/main-form-presentations.md#BKMK_MultipleForms).  
  
 When viewing the reading pane, people can rearrange the sections as they like. Their changes will be preserved as they navigate between records.  
  
### See also  
 [Create and design forms](../customize/create-design-forms.md)   
 [Use the form editor](../customize/use-the-form-editor.md)   
 [Design considerations for main forms](../customize/design-considerations-main-forms.md)   
 [Optimize form performance](../customize/optimize-form-performance.md)   
 [Manage auto-save](../customize/manage-auto-save.md)   
 
