---
title: "SLA table/entity reference (Microsoft Dynamics 365 Sales) | Microsoft Docs"
description: "Includes schema information and supported messages for the SLA table/entity with Microsoft Dynamics 365 Sales."
ms.date: 04/21/2024
ms.service: powerapps
ms.topic: reference
author: JimDaly
ms.author: jdaly
search.audienceType: 
  - developer
---

# SLA table/entity reference

Contains information about the tracked service-level KPIs for cases that belong to different customers.

> [!NOTE]
> The Microsoft Dynamics 365 Sales SLA table extends [SLA table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla) and [SLA table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/sla).
>
> This reference contains only the changes added by Microsoft Dynamics 365 Sales.
> See the [SLA table (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla) and [SLA table (Microsoft Dynamics 365)](/dynamics365/developer/reference/dataverse/entities/sla) reference documentation for more information.



## Customized columns/attributes

Microsoft Dynamics 365 Sales
modifies the definition of columns/attributes defined in other solutions. Listed by **SchemaName**.

### <a name="BKMK_ObjectTypeCode"></a> ObjectTypeCode

Changes from [ObjectTypeCode (Microsoft Dataverse)](/power-apps/developer/data-platform/reference/entities/sla#BKMK_ObjectTypeCode):

#### ObjectTypeCode Choices/Options

|Value|Label|
|---|---|
|10531|**Training Result**|
|10690|**Transcript**|
|10530|**Time spent in BPF**|
|10575|**Routing diagnostic item**|
|10494|**UntrackedAppointment**|
|10313|**Upgrade Run**|
|10576|**Routing diagnostic**|
|10318|**Unified Routing Setup Tracker**|
|10457|**Microsoft Teams chat suggestion**|
|10451|**Microsoft Teams Collaboration entity**|
|10371|**Tagged Record**|
|10456|**Microsoft Teams chat association entity**|
|10452|**Teams Dialer Admin settings**|
|10399|**Template Tag (Deprecated)**|
|10204|**Timeline Pin**|
|10339|**Template For Properties**|
|10386|**Template Parameter**|
|10314|**Upgrade Step**|
|10375|**msdyn_vivaorgsetting**|
|10376|**msdyn_vivausersetting**|
|10373|**msdyn_vivaentitysetting**|
|10374|**msdyn_vivaorgextensioncred**|
|10540|**Wall View**|
|10518|**wkwcolleaguesforcontact**|
|10519|**wkwconfig**|
|10541|**Filter**|
|10517|**wkwcolleaguesforcompany**|
|10692|**UR Notification Template Mapping**|
|10484|**Usage Metric**|
|10315|**Upgrade Version**|
|10691|**UR notification template**|
|11022|**Sales usage reporting**|
|10694|**Self service**|
|10372|**Copilot for Sales customer list**|
|10693|**User settings**|
|10206|**Virtual Table Column Candidate**|
|10606|**Swarm template**|
|10238|**Solution Health Rule**|
|10239|**Solution Health Rule Argument**|
|10240|**Solution Health Rule Set**|
|10482|**siconfig**|
|10483|**SI Key Value Config**|
|10385|**Session Template**|
|10474|**ShareAs Configuration**|
|10516|**Similar entities feature importance**|
|10123|**SLA KPI**|
|10444|**Smartassist configuration**|
|10710|**Skill Attachment Rule**|
|10711|**Attach Skill**|
|10688|**Audio File**|
|10599|**Suggestions Model Summary**|
|10600|**Suggestions Setting**|
|10598|**Suggestion request payload**|
|10807|**Suggestion Seller Priority**|
|10601|**Swarm**|
|10604|**Swarm role**|
|10605|**Swarm skill**|
|10602|**Swarm participant**|
|10603|**Swarm participant rule**|
|10495|**Suggested Activity**|
|10496|**Suggested Activity Data Source**|
|10689|**Sound notification setting**|
|10529|**Submodel Definition**|
|10497|**Suggested Contact**|
|10597|**Suggestion Interaction**|
|10806|**Suggestion Principal Object Access**|
|10498|**Suggested Contacts Data Source**|
|10805|**Suggestion Assignment Rule**|
|10183|**Workflow Action Status**|
|10544|**Customer Voice survey email template**|
|10545|**Customer Voice file response**|
|10542|**Customer Voice alert**|
|10543|**Customer Voice alert rule**|
|10546|**Customer Voice localized survey email template**|
|10549|**Customer Voice survey question response**|
|10550|**Customer Voice satisfaction metric**|
|10547|**Customer Voice project**|
|10548|**Customer Voice survey question**|
|10760|**TeleSign channel instance**|
|10761|**TeleSign channel instance account**|
|10759|**MockSmsProvider channel instance account**|
|10766|**Predefined Placeholder**|
|10749|**TrackingContext**|
|10764|**Vibes channel instance**|
|10765|**Vibes channel instance account**|
|10762|**Twilio channel instance**|
|10763|**Twilio channel instance account**|
|10551|**Customer Voice survey**|
|10273|**Basic Form**|
|10274|**Basic Form Metadata**|
|10271|**Column Permission Profile**|
|10272|**Content Snippet**|
|10275|**List**|
|10278|**Poll Placement**|
|10279|**Power Pages Core Entity DS**|
|10276|**Table Permission**|
|10277|**Page Template**|
|10554|**Customer Voice survey response**|
|10555|**Customer Voice unsubscribed recipient**|
|10552|**Customer Voice survey invite**|
|10553|**Customer Voice survey reminder**|
|10144|**Ms Graph Resource To Subscription**|
|10269|**Ad Placement**|
|10270|**Column Permission**|
|10308|**Catalog Submission Files**|
|10309|**Package Submission Store**|
|10758|**MockSmsProvider channel instance**|
|10559|**Code style**|
|10560|**Column style**|
|10557|**basestyle**|
|10558|**Button style**|
|10561|**Content Block**|
|10564|**imagestyle**|
|10565|**Layout Style**|
|10562|**Divider style**|
|10563|**General styles**|
|10800|**Work List View Configuration**|
|10801|**Work Queue Record**|
|10798|**Work List Suggestion**|
|10799|**Work list suggestion source**|
|10802|**Work Queue Record State**|
|10556|**AddToCalendar style**|
|10803|**Work list user setting**|
|10804|**WQDataSource**|
|10566|**QR code style**|
|10754|**Infobip channel instance**|
|10755|**Infobip channel instance account**|
|10751|**msdynmkt_experimentv2**|
|10750|**Marketing feature configuration**|
|10756|**Link mobility channel instance**|
|10768|**Metadata Item**|
|10769|**Metadata Store State**|
|10757|**Link mobility channel instance account**|
|10767|**Metadata Entity Relationship**|
|10752|**ACS channel instance**|
|10753|**ACS channel instance account**|
|10567|**Text style**|
|10568|**Video style**|
|10744|**CatalogEventStatusConfiguration**|
|10747|**Triggers To Sdk Message Processing Steps**|
|10748|**EventParameterMetadata**|
|10745|**Configuration**|
|10746|**Trigger**|
|10415|**Session Participant Data (Deprecated)**|
|10362|**Playbook activity**|
|10363|**Playbook activity attribute**|
|10679|**Personal sound setting**|
|10680|**Persona Security Role Mapping**|
|10364|**[DEPRECATED] Playbook category**|
|10221|**PM Analysis History**|
|10222|**PM Business Rule Automation Config**|
|10365|**Playbook**|
|10366|**[DEPRECATED] Playbook template**|
|10458|**Microsoft Orgchart node entity**|
|10317|**Originating Queue Mapping**|
|10514|**Opportunity KPI Item**|
|10532|**OpportunityModelConfig**|
|10614|**Overflow Action Config**|
|10429|**Pane tool configuration**|
|10678|**Personal quick reply**|
|10427|**Productivity pane configuration**|
|10428|**Pane tab configuration**|
|10223|**PM Calendar**|
|10539|**Post Rule Configuration**|
|10521|**Prediction Computation Operation**|
|10537|**Profile Album**|
|10538|**Post Configuration**|
|10522|**Prediction Model Status**|
|10525|**Predictive Score**|
|10526|**Predictive Scoring Sync Status**|
|10523|**Prediction Scheduled Operation**|
|10524|**Predictive Model Score**|
|10226|**PM Process Extended Metadata Version**|
|10227|**PM Process Template**|
|10224|**PM Calendar Version**|
|10225|**PM Inferred Task**|
|10228|**PM Process User Settings**|
|10231|**PM Template**|
|10232|**PM View**|
|10229|**PM Process Version**|
|10230|**PM Recording**|
|10677|**Operating Hour**|
|10659|**Recording**|
|10660|**Omnichannel Request**|
|10658|**OC Payment Profile**|
|10623|**Provisioning State**|
|10661|**Rich message**|
|10664|**Sentiment daily topic**|
|10665|**Sentiment daily topic keyword**|
|10662|**Rich message map**|
|10663|**Rule Item**|
|10704|**Conversation Capacity profile**|
|10708|**Conversation Characteristic**|
|10649|**Language**|
|10650|**Conversation**|
|10653|**Context item value**|
|10656|**Context variable**|
|10657|**Localization**|
|10654|**Live Work Item Participant (Deprecated)**|
|10655|**Conversation Sentiment**|
|10666|**Sentiment daily topic trending**|
|10477|**ODOSFeatureMetadata**|
|10670|**Message**|
|10671|**Tag**|
|10478|**ODOSMetadata**|
|10675|**Omnichannel Queue (Deprecated)**|
|10676|**Omnichannel Sync Config**|
|10673|**Omnichannel Configuration**|
|10674|**Omnichannel Personalization**|
|10668|**Session Participant Event**|
|10669|**Session Sentiment**|
|10667|**Session**|
|10709|**Session Characteristic**|
|10712|**Model training details**|
|10715|**Training record**|
|10716|**Skill finder model**|
|10713|**Training data import configuration**|
|10714|**Characteristic mapping**|
|10615|**Preferred Agent**|
|10782|**SARunInstance**|
|10175|**Schedule**|
|10797|**Insight**|
|10772|**Sales Tag**|
|10738|**SCI Conversation**|
|10741|**Custom Publisher**|
|10742|**EnvironmentSettings**|
|10739|**Custom Email Highlight**|
|10740|**Custom Highlight**|
|10378|**Org level settings for Sales Copilot apps**|
|11023|**Sales Copilot User Setting**|
|10791|**Sales Assignment Setting**|
|10377|**Sales Copilot Insight**|
|10489|**salesinsightssettings**|
|10781|**salesroutingdiagnostic**|
|10792|**Sales routing run**|
|10814|**SalesOmnichannel Message**|
|10815|**Text message template**|
|10743|**UserSettings**|
|10122|**Service Configuration**|
|10595|**Service Copilot Plugin**|
|10776|**Sequence Target Step**|
|10777|**Sequence Template**|
|10596|**Service Copilot Plugin Role**|
|10686|**Session event**|
|10687|**Session participant**|
|10813|**Sales provisioning request**|
|10414|**Session Data (Deprecated)**|
|10784|**segmentsetting**|
|10785|**Segment property**|
|10684|**Search Configuration**|
|10783|**Segment**|
|10786|**SegmentsUtil**|
|10774|**Sequence Stat**|
|10775|**Sequence Target**|
|10685|**Sentiment analysis**|
|10773|**Sequence**|
|10796|**Sales Acceleration settings**|
|10335|**Property Definition**|
|10336|**Property Asset Association**|
|10437|**Macro Solution Configuration**|
|10440|**Parameter definition**|
|10337|**Property Log**|
|10446|**Read Tracker**|
|10447|**Read tracking enabled information**|
|10338|**Property Template Association**|
|10682|**Provider**|
|10681|**Presence**|
|10434|**Action Input Parameter**|
|10616|**Preferred Agent Customer Identity**|
|10617|**Preferred Agent Routed Entity**|
|10435|**Action Output Parameter**|
|10436|**Macro Action Template**|
|10438|**Macro Connector**|
|10431|**Agent script**|
|10432|**Agent script step**|
|10527|**Real Time Scoring**|
|10619|**Routing configuration step**|
|10683|**RoutingRequest**|
|10202|**Rich Text Attachment**|
|10618|**Routing configuration**|
|10610|**Routing Rule Set Setting**|
|10780|**SABatchRunInstance**|
|10795|**Sales acceleration insights**|
|10574|**Rulesetentitymapping**|
|10779|**sabackupdiagnostic**|
|10737|**Recording**|
|10473|**Forecast Recurrence**|
|10528|**Real Time Scoring Operation**|
|10472|**Recompute Tracker**|
|10479|**Recurring Sales Action**|
|10481|**msdyn_relationshipinsightsunifiedconfig**|
|10826|**Report Bookmark**|
|10480|**Recurring Sales Action V2**|
|10515|**Relationship Analytics Metadata**|
|10280|**Publishing State**|
|4009|**Site**|
|1038|**Sales Literature**|
|1070|**Sales Attachment**|
|32|**Sales Process Instance**|
|1088|**Order**|
|1089|**Order Product**|
|4214|**Service Activity**|
|20|**Service Contract Contact**|
|10249|**SearchAttributeSettings**|
|10250|**SearchCustomAnalyzer**|
|10251|**SearchRelationshipSettings**|
|4001|**Service**|
|11024|**SearchResultsCache**|
|10252|**Search Telemetry**|
|1056|**Unit Group**|
|1055|**Unit**|
|9943|**Topic Model Execution History**|
|10150|**UserMobileOfflineProfileMembership**|
|10185|**User Rating**|
|10145|**Virtual Entity  Metadata**|
|10322|**Virtual Resource Group Resource**|
|9942|**Topic Model Configuration**|
|10141|**SupportUserTable**|
|9946|**Topic History**|
|9944|**Topic Model**|
|9948|**Text Analytics Topic**|
|10149|**TeamMobileOfflineProfileMembership**|
|10119|**PDF Setting**|
|952|**Phone To Case Process**|
|10152|**OrganizationDataSyncSubscriptionEntity**|
|10153|**OrganizationDataSyncSubscriptionFnoTable**|
|10242|**powerbidatasetapdx**|
|10243|**Power BI Mashup Parameter**|
|10241|**Power BI Dataset**|
|10244|**Power BI Report**|
|10254|**Site Component**|
|10255|**Site**|
|10245|**powerbireportapdx**|
|10143|**PowerfxRule**|
|10151|**OrganizationDataSyncSubscription**|
|10292|**Web Page**|
|10293|**Web Page Access Control Rule**|
|10290|**Web Link**|
|10291|**Web Link Set**|
|10294|**Web Role**|
|10297|**Website Language**|
|10298|**Web Template**|
|10295|**Website**|
|10296|**Website Access**|
|10283|**Shortcut**|
|10284|**Site Marker**|
|10281|**Publishing State Transition Rule**|
|10282|**Redirect**|
|10285|**Site Setting**|
|10288|**Multistep Form Metadata**|
|10289|**Form Step**|
|10286|**Web File**|
|10287|**Multistep Form**|
|1083|**Opportunity Product**|
|953|**Opportunity Sales Process**|
|4208|**Opportunity Close**|
|25|**OpportunityCompetitors**|
|10154|**OrganizationDataSyncFnoState**|
|10155|**OrganizationDataSyncState**|
|4209|**Order Close**|
|3|**Opportunity**|
|10256|**Site Language**|
|4002|**Resource**|
|4005|**Scheduling Group**|
|10321|**resource group data source**|
|10167|**RetentionCleanupInfo**|
|4010|**Resource Expansion**|
|4006|**Resource Specification**|
|10191|**Recycle Bin Configuration**|
|10168|**RetentionCleanupOperation**|
|10189|**RoleEditorLayout**|
|10171|**RetentionOperation**|
|10172|**RetentionOperationDetail**|
|10169|**RetentionConfig**|
|10170|**RetentionFailureDetail**|
|1024|**Product**|
|1025|**Product Association**|
|1028|**Product Relationship**|
|1026|**Price List Item**|
|21|**ProductSalesLiterature**|
|10257|**Power Pages Site Published**|
|1022|**Price List**|
|1144|**Rating Model**|
|1142|**Rating Value**|
|10164|**ReconciliationEntityInfo**|
|10165|**ReconciliationEntityStepInfo**|
|10166|**ReconciliationInfo**|
|4211|**Quote Close**|
|1085|**Quote Product**|
|1084|**Quote**|
|10648|**Flagged spam**|
|9702|**Entitlement Template**|
|9703|**Entitlement Template Channel**|
|9704|**Entitlement Entity Allocation Type Mapping**|
|6363|**Entitlement Product**|
|4545|**Entitlement Template Product**|
|9701|**Entitlement Channel**|
|7272|**Entitlement Contact**|
|10162|**EnableArchivalRequest**|
|9700|**Entitlement**|
|4000|**Facility/Equipment**|
|10190|**Deleted Item Reference**|
|4503|**Opportunity Relationship**|
|1013|**Discount**|
|1333|**Property Instance**|
|1049|**Property Option Set Item**|
|1048|**Property**|
|1235|**Property Association**|
|1080|**Discount List**|
|9954|**Knowledge Article Incident**|
|4|**Lead**|
|1090|**Invoice**|
|1091|**Invoice Product**|
|1017|**Lead Address**|
|10248|**MakerFewShot**|
|10247|**MainFewShot**|
|954|**Lead To Opportunity Sales Process**|
|24|**LeadCompetitors**|
|27|**LeadProduct**|
|10310|**List Operation**|
|4300|**Marketing List**|
|4301|**Marketing List Member**|
|10142|**FxExpression**|
|11032|**Flow Credential Application**|
|112|**Case**|
|9931|**Incident KnowledgeBaseRecord**|
|4206|**Case Resolution**|
|10156|**ArchiveCleanupInfo**|
|10157|**ArchiveCleanupOperation**|
|10184|**Notification**|
|1147|**Bookable Resource Category**|
|1149|**Bookable Resource Category Assn**|
|4421|**Bookable Resource Booking to Exchange Id Mapping**|
|1146|**Bookable Resource Booking Header**|
|1148|**Bookable Resource Characteristic**|
|1151|**Bookable Resource Group**|
|1152|**Booking Status**|
|10319|**Available Times**|
|10320|**Available Times Data Source**|
|1150|**Bookable Resource**|
|1145|**Bookable Resource Booking**|
|10146|**Background Operation**|
|10368|**admin_settings_entity**|
|10316|**Activity monitor**|
|10262|**Invite Redemption**|
|10263|**Portal Comment**|
|10260|**External Identity**|
|10261|**Invitation**|
|16|**AccountLeads**|
|10120|**Activity File Attachment**|
|10264|**Setting**|
|10193|**App Action Migration**|
|10194|**App Action Rule**|
|10192|**App Action**|
|10265|**Multistep Form Session**|
|10912|**Chatbot content pack**|
|10118|**Comment**|
|113|**Child Incident Count**|
|4215|**Commitment**|
|1006|**Competitor Product**|
|26|**CompetitorSalesLiterature**|
|123|**Competitor**|
|1004|**Competitor Address**|
|10253|**CopilotExampleQuestion**|
|17|**ContactInvoices**|
|22|**ContactLeads**|
|4007|**Resource Group**|
|19|**ContactOrders**|
|1011|**Contract Line**|
|2011|**Contract Template**|
|18|**ContactQuotes**|
|1010|**Contract**|
|10121|**Teams chat**|
|4400|**Campaign**|
|4402|**Campaign Activity**|
|10160|**BulkArchiveOperation**|
|10161|**BulkArchiveOperationDetail**|
|10158|**BulkArchiveConfig**|
|10159|**BulkArchiveFailureDetail**|
|4405|**Bulk Operation Log**|
|4406|**Quick Campaign**|
|4404|**Campaign Activity Item**|
|1141|**Characteristic**|
|4403|**Campaign Item**|
|4401|**Campaign Response**|
|10197|**Card**|
|10198|**Card State Item**|
|10201|**Entity link chat configuration**|
|10487|**EntityRankingRule**|
|10636|**Deprecated Workstream Entity Configuration**|
|10461|**Entity Delta Change**|
|10794|**Extended User Setting**|
|10133|**Favorite knowledge article**|
|10637|**Entity**|
|10722|**Entity-Workstream Map**|
|10179|**Data Movement Service Request Status**|
|10180|**DMS Sync Request**|
|10460|**Distributed Lock**|
|10178|**Data Movement Service Request**|
|10181|**DMS Sync Status**|
|10717|**Effort estimate**|
|10607|**Entity Attachment**|
|10809|**Duplicate Detection Plugin Run**|
|10810|**Duplicate Lead Mapping**|
|10126|**Knowledge Federated Article**|
|10470|**Forecast Prediction Status**|
|10471|**Forecast recurrence**|
|10468|**Forecast**|
|10469|**Forecast Prediction Data**|
|10836|**Forecast Summary and Setting**|
|10723|**ICD Extension**|
|10334|**Functional Location**|
|10476|**GDPRData**|
|10462|**File Upload Status Tracker**|
|10488|**flowcardtype**|
|10127|**Knowledge Federated Article Incident**|
|10246|**File Upload**|
|10463|**Forecast**|
|10466|**Forecasting Cache**|
|10467|**Forecast Insights**|
|10464|**Forecast Configuration**|
|10465|**Forecast definition**|
|10771|**DigitalSellingCompletedTask**|
|10833|**Customer Service historical analytics**|
|10834|**Forecast**|
|10824|**Data Analytics Dataset**|
|10817|**Data Analytics Report**|
|10835|**Knowledge analytics**|
|11019|**Omnichannel voice historical analytics (preview) (Deprecated)**|
|10819|**Sales acceleration reports**|
|11018|**Omnichannel historical analytics**|
|11020|**Omnichannel Realtime analytics**|
|10333|**Customer Asset Category**|
|10475|**Customer email communication**|
|10329|**Customer Asset**|
|10332|**Customer Asset Attachment**|
|10507|**Daily Kpis for account**|
|10510|**Daily kpis for Opportunity**|
|10823|**Data Analytics User Customized Report**|
|10508|**Daily kpis for contact**|
|10509|**Daily kpis for lead**|
|11021|**Sales usage telemetry reports**|
|10502|**Deal manager settings**|
|10572|**Decision contract**|
|10187|**Insights Store Data Source**|
|10501|**dealmanageraccess**|
|10573|**Decision rule set**|
|10635|**DeletedConversation**|
|10770|**DigitalSellingActiveTask**|
|10425|**msdyn_DefExtendedChannelInstance**|
|10426|**msdyn_DefExtendedChannelInstanceAccount**|
|10177|**Dataflow DatalakeFolder**|
|10825|**Data Analytics Workspace**|
|10312|**Database Version**|
|10174|**Dataflow Connection Reference**|
|10808|**Data Hygiene Setting Info**|
|10818|**Insights**|
|10176|**Dataflow Template**|
|10500|**icebreakersconfig**|
|10703|**Work stream capacity profile**|
|10439|**Macro Run History**|
|10639|**Live work item event**|
|10640|**Work Stream**|
|10641|**Masking Rule**|
|10186|**Mobile App**|
|10536|**ModelPreviewStatus**|
|10609|**Master Entity Routing Configuration**|
|10323|**Migration tracker**|
|10412|**KPI Event Data**|
|10413|**KPI Event Definition**|
|10139|**Knowledge search filter**|
|10132|**Knowledge Search Insight**|
|10811|**Lead Hygiene Setting**|
|10812|**Linked Entity Attribute Validity**|
|10638|**Ongoing conversation (Deprecated)**|
|10511|**Lead KPI Item**|
|10535|**LeadModelConfig**|
|10182|**Module Run Detail**|
|10643|**Bot Channel Registration Secret**|
|10644|**Omnichannel channel api conversation privilege**|
|10642|**Auto block rule**|
|10620|**Bot Channel Registration**|
|10645|**Omnichannel channel api message privilege**|
|10622|**Channel State Configuration**|
|10647|**External context**|
|10646|**Channel api method mapping**|
|10621|**Channel Configuration**|
|10449|**msdyn_msteamssetting**|
|10450|**msdyn_msteamssettingsv2**|
|10512|**Most Contacted**|
|10513|**Most Contacted By**|
|10384|**Notification Template**|
|10672|**Geo Location Provider**|
|10499|**Notes analysis Config**|
|10383|**Notification Field**|
|10138|**Knowledge search personal filter config**|
|10346|**IoT Device Command**|
|10347|**IoT Device Command Definition**|
|10344|**IoT Device**|
|10345|**IoT Device Category**|
|10348|**IoT Device Data History**|
|10351|**IoT Device Visualization Configuration**|
|10352|**IoT Field Mapping**|
|10349|**IoT Device Property**|
|10350|**IoT Device Registration History**|
|10577|**Inbox card configuration**|
|10578|**Inbox Configuration**|
|10718|**Effort estimation model**|
|10719|**Effort model training details**|
|10579|**Inbox Entity Configuration**|
|10325|**Intent**|
|10343|**IoT Alert**|
|10188|**Insights Store Virtual Entity**|
|10124|**Integrated search provider**|
|10353|**IoT Property Definition**|
|10129|**Knowledge Article Image**|
|10593|**Knowledge Article Suggestion**|
|10128|**Search provider**|
|10136|**Knowledge personalization**|
|10594|**Knowledge Article Suggestion Data Source**|
|10131|**Knowledge Interaction Insight**|
|10125|**Knowledge Management Setting**|
|10137|**Knowledge Article Template**|
|10130|**Knowledge Configuration**|
|10356|**IoT Settings**|
|10359|**IoT Alert to Case Process**|
|10354|**IoT Provider**|
|10355|**IoT Provider Instance**|
|10326|**JobsState**|
|10592|**KB Enrichment**|
|10837|**Keywords Description Suggestion Setting**|
|10134|**Knowledge article language setting**|
|10135|**Knowledge Article Attachment**|
|10203|**Custom Control Extended Setting**|
|10236|**Analysis Result**|
|10237|**Analysis Result Detail**|
|10234|**Analysis Job**|
|10235|**Analysis Override**|
|10626|**Power BI Configuration**|
|10379|**App profile**|
|10580|**App Profile Copilot Configuration**|
|10816|**Data Analytics Admin Settings (Deprecated)**|
|10828|**[Deprecated] Dynamics Customer Service Analytics**|
|10210|**AI Object Detection Image**|
|10207|**AI Event**|
|10209|**AI Form Processing Document**|
|10211|**AI Object Detection Label**|
|10233|**Analysis Component**|
|10212|**AI Object Detection Bounding Box**|
|10213|**AI Object Detection Image Mapping**|
|10173|**App Insights Metadata**|
|10520|**Attribute Influence Statistics**|
|10789|**Seller attribute value**|
|10787|**Assignment Rule**|
|10788|**Seller attribute**|
|10627|**Authentication Settings**|
|10493|**Auto Capture Settings**|
|10324|**BgJobLedger**|
|10628|**Auth Settings Entry**|
|10492|**Auto Capture Rule**|
|10382|**App profile role mapping**|
|10569|**App state**|
|10380|**Application Extension**|
|10381|**Application Tab Template**|
|10327|**Asset Category Template Association**|
|10612|**Assignment Configuration Step**|
|10790|**Assignment Map**|
|10328|**Asset Template Association**|
|10611|**Assignment Configuration**|
|10453|**Teams Contact Suggestion by AI**|
|10503|**Account KPI Item**|
|10490|**Action Card Usage**|
|10148|**MobileOfflineProfileItemFilter**|
|10485|**Action Card Regarding**|
|10721|**Active ICD Extension**|
|10504|**Activity Analysis CleanUp State**|
|10486|**Action Card Role Setting**|
|10491|**Action Card Usage Aggregation**|
|10163|**MetadataForArchival**|
|10311|**Marketing Form Display Attributes**|
|10147|**MobileOfflineProfileExtension**|
|10505|**Relationship Analytics Config**|
|10216|**AI Builder Dataset File**|
|10217|**AI Builder Dataset Record**|
|10625|**Agent Status history**|
|10215|**AI Builder Dataset**|
|10218|**AI Builder Datasets Container**|
|10220|**AI Builder File Attached Data**|
|10208|**AI Builder Feedback Loop**|
|10219|**AI Builder File**|
|10624|**AdminAppState**|
|10705|**Agent Capacity Profile Unit**|
|10443|**Adaptive Card Configuration**|
|10459|**Forecast Manual Adjustment History**|
|10701|**Agent capacity update history**|
|10827|**Agent Resource Forecasting**|
|10707|**Agent Status**|
|10706|**Agent Channel State**|
|10581|**Agent Copilot Setting**|
|10702|**Bookable Resource Capacity Profile**|
|10728|**Conversation Participant Sentiment**|
|10729|**Conversation Question**|
|10634|**Conversation Message Block**|
|10727|**Conversation Participant Insights**|
|10730|**Conversation Segment Sentiment**|
|10733|**Conversation Subject**|
|10822|**conversationsuggestionrequestpayload**|
|10731|**Conversation Sentiment**|
|10732|**Conversation Signal**|
|10632|**Conversation Action**|
|10724|**Conversation Action Item**|
|10454|**Contact suggestion rule**|
|10455|**Contact suggestion ruleset**|
|10633|**Conversation Action Locale**|
|10411|**Conversation Data (Deprecated)**|
|10720|**ConversationInsight**|
|10725|**Conversation Aggregated Insights**|
|10726|**Comment**|
|11012|**Conversation Summary Interaction**|
|10582|**Copilot Summarization Setting**|
|10590|**Copilot Transcript**|
|10588|**Copilot Interaction**|
|10589|**Copilot Interaction Data**|
|10591|**Copilot Transcript Data**|
|10608|**Customer Service Key Value Configuration**|
|10571|**Custom API Ruleset Configuration**|
|10370|**CRM Connection**|
|10570|**CSAdminConfig**|
|10735|**Conversation System Tag**|
|10736|**Conversation Tag**|
|11013|**Conversation Summary Setting**|
|10734|**Conversation Summary Suggestion**|
|11014|**Conversation Topic**|
|11016|**Conversation Topic Summary**|
|10587|**Agent Preference For Copilot**|
|11017|**Conversation topic Conversation mapping**|
|11015|**Conversation Topic Setting**|
|10506|**Contact KPI Item**|
|10831|**Case Topic Summary**|
|10630|**Entity Routing Context**|
|10832|**Case topic Incident mapping**|
|10830|**Case Topic Setting**|
|10631|**Channel Capability**|
|10418|**Channel Definition Locale**|
|10419|**Channel Instance**|
|10416|**Channel Definition**|
|10417|**Channel Definition Consent**|
|10629|**Quick reply**|
|10613|**Capacity Profile**|
|10821|**Bot Session**|
|10361|**Playbook Callable Context**|
|10583|**Case Enrichment**|
|10586|**Case Suggestions Data Souce**|
|10829|**Case Topic**|
|10584|**Case Suggestion**|
|10585|**Case Suggestion Request Payload**|
|10420|**Channel Instance Account**|
|10394|**Notification Template (Deprecated)**|
|10396|**Session Templates (Deprecated)**|
|10205|**Virtual Connector Data Source**|
|10393|**Notification Field (Deprecated)**|
|10397|**Application Tab Template (Deprecated)**|
|10395|**App Parameter Definition (Deprecated)**|
|10424|**Consuming Application**|
|10398|**Parameter (Deprecated)**|
|10400|**Application Type (Deprecated)**|
|10423|**Channel Message Part**|
|10409|**Channel Integration Framework v2.0 Provider**|
|10421|**Channel Message Attachment**|
|10422|**Channel Message Context Part**|
|10392|**Channel Integration Framework v1.0 Provider**|
|10448|**Microsoft Teams Graph resource Entity**|
|10369|**Collab Space Team Association**|



### See also

[Dataverse table/entity reference](../about-entity-reference.md)  
[Dataverse Web API Reference](/power-apps/developer/data-platform/webapi/reference/about)   
<xref:Microsoft.Dynamics.CRM.sla?displayProperty=fullName>
