
namespace PackageManagerTool.Core.Utilities
{
    public struct Db
    {
        public struct TrackingSystem
        {
            public const string Name = "tracking_system_1_schema";
            public struct Functions
            {

            }
            public struct Procedures
            {

            }
            public struct Queries
            {

                /// <summary>
                /// Get Stocks Client. Accepts 1 parameter (@Imei).
                /// </summary>
                #region GetClient
                public const string GetClient = @"  SELECT
                                                        scm.from_client 
                                                    FROM
		                                                receiving_table rt   
                                                        JOIN stock_shipment_unit ssu ON  ssu.device_imei =  rt.imei 
                                                        JOIN stock_client_matrix scm ON scm.scm_id = ssu.scm_id
                                                    WHERE
                                                        rt.imei = @Imei
		                                            AND scm.from_client = rt.clientcode
		                                            AND ssu.from_client_batch = rt.batchnum
                                                    AND ssu.void_record_id = 0;";
                #endregion



                /// <summary>
                /// Get IMEI Data in Receiving. Accepts 2 parameters (@DeviceIMEI AND @Client).
                /// </summary>
                #region GetIMEIData
                public const string GetIMEIData = @"    SELECT
                                                            rt.imei 'IMEI',
                                                            rt.partno 'PartNo',
                                                            rt.gradebatch 'Grade',
                                                            rt.dcoverversion 'DcoverVer',
                                                            rt.simcarrier 'Carrier',
                                                            rt.serialnum 'SerialNo',
                                                            rt.clientcode 'Client',
                                                            CASE

						                                                        WHEN rt.modelname LIKE 'IP6 %' THEN 'iPhone 6'
						                                                        WHEN rt.modelname LIKE 'IP6S %' THEN 'iPhone 6s'
						                                                        WHEN rt.modelname LIKE 'IP6+ %' THEN 'iPhone 6 Plus'
						                                                        WHEN rt.modelname LIKE 'IP6S+ %' THEN 'iPhone 6s Plus'

						                                                        WHEN rt.modelname LIKE 'IP7 %' THEN 'iPhone 7'
						                                                        WHEN rt.modelname LIKE 'IP7+ %' THEN 'iPhone 7 Plus'
                                                                                WHEN rt.modelname LIKE 'IP8 %' THEN 'iPhone 8'
                                                                                WHEN rt.modelname LIKE 'IP8+ %' THEN 'iPhone 8 Plus'
                                                                                WHEN rt.modelname LIKE 'IPX %' THEN 'iPhone X'
						                                                        ELSE 'N/A'
					                                                        END 'Model',
	
					                                                        CASE
						                                                        WHEN rt.modelname LIKE '%16%' THEN '16'
						                                                        WHEN rt.modelname LIKE '%32%' THEN '32'
						                                                        WHEN rt.modelname LIKE '%64%' THEN '64'
						                                                        WHEN rt.modelname LIKE '%128%' THEN '128'
						                                                        WHEN rt.modelname LIKE '%256%' THEN '256'
						                                                        WHEN rt.modelname LIKE '%512%' THEN '512'

						                                                        ELSE 'N/A'
					                                                        END 'Size',
	
	
	                                                        CASE
						                                                        WHEN rt.modelname LIKE '%B' THEN 'Matte Black'
						                                                        WHEN rt.modelname LIKE '%BLU' THEN 'BLU'
						                                                        WHEN rt.modelname LIKE '%GLD' THEN 'Gold'
						                                                        WHEN rt.modelname LIKE '%GRN' THEN 'GRN'
						                                                        WHEN rt.modelname LIKE '%GRY' THEN 'Space Gray'
						                                                        WHEN rt.modelname LIKE '%PNK' THEN 'PNK'
						                                                        WHEN rt.modelname LIKE '%SVR' THEN 'Silver'
						                                                        WHEN rt.modelname LIKE '%WHT' THEN 'WHT'
						                                                        WHEN rt.modelname LIKE '%YLW' THEN 'YLW'
						                                                        WHEN rt.modelname LIKE '%RGD' THEN 'Rose Gold'
						                                                        WHEN rt.modelname LIKE '%BLK' THEN 'Matte Black'
						                                                        WHEN rt.modelname LIKE '%JBK' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%JBLK' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%JET' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%RED' THEN 'Product Red'

						                                                        ELSE 'N/A'
					                                                        END 'Color'
                                                        FROM
                                                            receiving_table rt 
                                                        WHERE
                                                            rt.imei = @DeviceIMEI
                                                        AND rt.clientcode = @Client;";
                #endregion

                /// <summary>
                /// Get IMEI Data in Receiving only for ECO - JP. Accepts 2 parameters (@DeviceIMEI AND @Client).
                /// </summary>
                #region JPGetIMEIData
                public const string JPGetIMEIData = @"    SELECT
                                                            rt.imei 'IMEI',
                                                            rt.partno 'PartNo',
                                                            rt.gradebatch 'Grade',
                                                            rt.dcoverversion 'DcoverVer',
                                                            rt.simcarrier 'Carrier',
                                                            rt.serialnum 'SerialNo',
                                                            rt.clientcode 'Client',
                                                            CASE

						                                                        WHEN rt.modelname LIKE 'IP6 %' THEN 'IPHONE 6'
						                                                        WHEN rt.modelname LIKE 'IP6S %' THEN 'IPHONE 6S'
						                                                        WHEN rt.modelname LIKE 'IP6+ %' THEN 'IPHONE 6 PLUS'
						                                                        WHEN rt.modelname LIKE 'IP6S+ %' THEN 'IPHONE 6S PLUS'

						                                                        WHEN rt.modelname LIKE 'IP7 %' THEN 'IPHONE 7'
						                                                        WHEN rt.modelname LIKE 'IP7+ %' THEN 'IPHONE 7 PLUS'
                                                                                WHEN rt.modelname LIKE 'IP8 %' THEN 'IPHONE 8'
                                                                                WHEN rt.modelname LIKE 'IP8+ %' THEN 'IPHONE 8 PLUS'
                                                                                WHEN rt.modelname LIKE 'IPX %' THEN 'IPHONE X'
						                                                        ELSE 'N/A'
					                                                        END 'Model',
	
					                                                        CASE
						                                                        WHEN rt.modelname LIKE '%16%' THEN '16'
						                                                        WHEN rt.modelname LIKE '%32%' THEN '32'
						                                                        WHEN rt.modelname LIKE '%64%' THEN '64'
						                                                        WHEN rt.modelname LIKE '%128%' THEN '128'
						                                                        WHEN rt.modelname LIKE '%256%' THEN '256'
						                                                        WHEN rt.modelname LIKE '%512%' THEN '512'

						                                                        ELSE 'N/A'
					                                                        END 'Size',
	
	
	                                                        CASE
						                                                        WHEN rt.modelname LIKE '%B' THEN 'BLACK'
						                                                        WHEN rt.modelname LIKE '%BLU' THEN 'BLU'
						                                                        WHEN rt.modelname LIKE '%GLD' THEN 'GOLD'
						                                                        WHEN rt.modelname LIKE '%GRN' THEN 'GRN'
						                                                        WHEN rt.modelname LIKE '%GRY' THEN 'SPACE GRAY'
						                                                        WHEN rt.modelname LIKE '%PNK' THEN 'PNK'
						                                                        WHEN rt.modelname LIKE '%SVR' THEN 'SILVER'
						                                                        WHEN rt.modelname LIKE '%WHT' THEN 'WHT'
						                                                        WHEN rt.modelname LIKE '%YLW' THEN 'YLW'
						                                                        WHEN rt.modelname LIKE '%RGD' THEN 'ROSE GOLD'
						                                                        WHEN rt.modelname LIKE '%BLK' THEN 'BLACK'
						                                                        WHEN rt.modelname LIKE '%JBK' THEN 'JET BLACK'
						                                                        WHEN rt.modelname LIKE '%JBLK' THEN 'JET BLACK'
						                                                        WHEN rt.modelname LIKE '%JET' THEN 'JET BLACK'
						                                                        WHEN rt.modelname LIKE '%RED' THEN 'RED'

						                                                        ELSE 'N/A'
					                                                        END 'Color'
                                                        FROM
                                                            receiving_table rt 
                                                        WHERE
                                                            rt.imei = @DeviceIMEI
                                                        AND rt.clientcode = @Client;";
                #endregion


                /// <summary>
                /// Get Packaging Type. Accepts 1 parameters (@Imei).
                /// </summary>
                #region GetPackagingTypeData
                public const string GetPackagingTypeData = @"   SELECT
	                                                                package_description 
	                                                            FROM
	                                                               packaging_type 
                                                                WHERE
                                                                pt_id = (
	                                                                SELECT
		                                                                scm.packaging_type ->> '$.TYPE' 
	                                                                FROM
		                                                                receiving_table rt
	                                                                JOIN stock_shipment_unit ssu ON ssu.device_imei = rt.imei 

	                                                                LEFT JOIN stock_client_matrix scm ON scm.scm_id = ssu.scm_id
	                                                                WHERE
		                                                                rt.imei = @Imei
		                                                                AND scm.from_client = rt.clientcode
		                                                                AND ssu.from_client_batch = rt.batchnum
		                                                                AND ssu.void_record_id = 0 
		                                                                AND scm.isactive = 1 
		                                                                ANd scm.VoidRecordID = 0
                                                                );";
                #endregion

                /// <summary>
                /// Get Hashed Password. Accepts 1 parameters (@username).
                /// </summary>
                #region GetPasswordHash
                public const string GetPasswordHash = @"   SELECT
                                                                    u.PASSWORD 
                                                                FROM
                                                                    parts.USER u 
                                                                WHERE
                                                                    u.username = @Username 
                                                                    AND u.UserTypeId IN ( 1, 35, 36 ) 
                                                                    AND u.IsActive = 1
                                                                    AND u.IsDeleted = 0;";
                #endregion


                /// <summary>
                /// Get Printing Data. Accepts 2 parameters (@Imei AND @Client).
                /// </summary>
                #region GetPrintData
                public const string GetPrintData = @"   SELECT
                                                            CONCAT( x.IPHONE, ' ', x.Model, ' ', x.Color, ' ', x.Size ) 'Model',
                                                            x.PartNo,
                                                            x.IMEI,
                                                            x.Carrier 
                                                        FROM
                                                            (
                                                        SELECT
                                                            'IPHONE',
                                                        CASE

                                                            WHEN rt.modelname LIKE 'IP4G %' THEN
                                                            '4' 
                                                            WHEN rt.modelname LIKE 'IP4S %' THEN
                                                            '4S' 
                                                            WHEN rt.modelname LIKE 'IP5 %' THEN
                                                            '5' 
                                                            WHEN rt.modelname LIKE 'IP5C %' THEN
                                                            '5C' 
                                                            WHEN rt.modelname LIKE 'IP5S %' THEN
                                                            '5S' 
                                                            WHEN rt.modelname LIKE 'IP6 %' THEN
                                                            '6' 
                                                            WHEN rt.modelname LIKE 'IP6S %' THEN
                                                            '6S' 
                                                            WHEN rt.modelname LIKE 'IP6+ %' THEN
                                                            '6 PLUS' 
                                                            WHEN rt.modelname LIKE 'IP6S+ %' THEN
                                                            '6S PLUS' 
                                                            WHEN rt.modelname LIKE 'IP7 %' THEN
                                                            '7' 
                                                            WHEN rt.modelname LIKE 'IP7+ %' THEN
                                                            '7 PLUS' 
                                                            WHEN rt.modelname LIKE 'IP8 %' THEN
                                                            '8' 
                                                            WHEN rt.modelname LIKE 'IP8+ %' THEN
                                                            '8 PLUS' 
                                                            ELSE 'N/A' 
                                                            END 'Model',
                                                        CASE

                                                                WHEN rt.modelname LIKE '%B' THEN
                                                                'BLACK' 
                                                                WHEN rt.modelname LIKE '%W' THEN
                                                                'WHITE' 
                                                                WHEN rt.modelname LIKE '%BLU' THEN
                                                                'BLUE' 
                                                                WHEN rt.modelname LIKE '%GLD' THEN
                                                                'GOLD' 
                                                                WHEN rt.modelname LIKE '%GRN' THEN
                                                                'GREEN' 
                                                                WHEN rt.modelname LIKE '%GRY' THEN
                                                                'GRAY' 
                                                                WHEN rt.modelname LIKE '%PNK' THEN
                                                                'PINK' 
                                                                WHEN rt.modelname LIKE '%SVR' THEN
                                                                'SILVER' 
                                                                WHEN rt.modelname LIKE '%WHT' THEN
                                                                'WHITE' 
                                                                WHEN rt.modelname LIKE '%YLW' THEN
                                                                'YELLOW' 
                                                                WHEN rt.modelname LIKE '%RGD' THEN
                                                                'ROSEGOLD' 
                                                                WHEN rt.modelname LIKE '%BLK' THEN
                                                                'BLACK' 
                                                                WHEN rt.modelname LIKE '%JBK' THEN
                                                                'JET BLACK' 
                                                                WHEN rt.modelname LIKE '%JBLK' THEN
                                                                'JET BLACK' 
                                                                WHEN rt.modelname LIKE '%JET' THEN
                                                                'JET BLACK' 
                                                                WHEN rt.modelname LIKE '%RED' THEN
                                                                'RED' ELSE 'N/A' 
                                                            END 'Color',
                                                        CASE

                                                                WHEN rt.modelname LIKE '%16%' THEN
                                                                '16GB' 
                                                                WHEN rt.modelname LIKE '%32%' THEN
                                                                '32GB' 
                                                                WHEN rt.modelname LIKE '%64%' THEN
                                                                '64GB' 
                                                                WHEN rt.modelname LIKE '%128%' THEN
                                                                '128GB' 
                                                                WHEN rt.modelname LIKE '%256%' THEN
                                                                '256GB' 
                                                                WHEN rt.modelname LIKE '%512%' THEN
                                                                '512GB' ELSE 'N/A' 
                                                            END 'Size',
                                                            rt.partno 'PartNo',
                                                            rt.imei 'IMEI',
                                                            IFNULL( ccm.Carrier, 'UNDEFINED' ) 'Carrier' 
                                                        FROM
                                                            receiving_table rt
                                                        LEFT JOIN client_carrier_matrix ccm ON ( ccm.Client, ccm.Carrier ) = ( rt.clientcode, rt.simcarrier ) 
                                                        WHERE
                                                            rt.clientcode = @Client
                                                            AND rt.imei = @DeviceIMEI
                                                            AND ccm.IsActive = 1
                                                        ) x;";

                #endregion



                /// <summary>
                /// Get Ship to Client. Accepts 1 parameters (@Imei).
                /// </summary>
                #region GetShiptoClient
                public const string GetShiptoClient = @"   SELECT
                                                                scm.ship_to_client 
                                                            FROM
		                                                        receiving_table rt
                                                            JOIN  stock_shipment_unit ssu 
                                                                ON ssu.device_imei = rt.imei
		                                                    JOIN stock_client_matrix scm 
                                                                ON scm.scm_id = ssu.scm_id
                                                            WHERE
                                                                rt.imei = @Imei
		                                                    AND scm.from_client = rt.clientcode
		                                                    AND ssu.from_client_batch = rt.batchnum
                                                            AND ssu.void_record_id = 0;";
                #endregion


                /// <summary>
                /// Check if LCM is OQC. Accepts 1 parameters (@Imei).
                /// </summary>
                #region OQCChecker
                public const string OQCChecker = @"     SELECT
	                                                        IF(SUBSTRING(i.Barcode2,1,3)='OQC',1,0) 'isOQC?'
                                                        FROM
	                                                        phoneattributetrail pat
                                                        JOIN parts.inventory i
	                                                        ON i.Id = pat.LCMInventoryId

                                                        WHERE
	                                                        pat.imei = @Imei 
	                                                        AND pat.VoidRecordId IS NULL";
                #endregion

                /// <summary>
                /// Check if LCM is OQC for RMA Units. Accepts 1 parameters (@Imei).
                /// </summary>
                #region RMAOQCChecker
                public const string RMAOQCChecker = @"     SELECT
                                                                IF
	                                                            ( SUBSTRING( i.Barcode2, 1, 3 ) = 'OQC', 1, 0 ) 'isOQC?' 
                                                            FROM
	                                                            phoneattributetrail pat
	                                                            JOIN parts.inventory i ON i.Id = pat.LCMInventoryId 
                                                            WHERE
	                                                            pat.imei = @Imei 
	                                                            AND pat.DateCombo = 
	                                                            (
	                                                            SELECT
	                                                            max(_pat.DateCombo)
	                                                            FROM phoneattributetrail _pat
	                                                            WHERE _pat.Imei = pat.Imei
	                                                            )";
                #endregion

                /// <summary>
                /// Allowed User To Print. Accepts 4 parameters (@Imei, @printedBy,@username, AND  @Workstation).
                /// </summary>
                #region AuthenticateUser
                public const string AuthenticateUser = @"INSERT INTO 
                                                           printlogs
                                                        VALUES
                                                           (
                                                               DEFAULT,
                                                               2,
                                                               @Imei,
                                                               NOW(),
                                                               @printedBy,
                                                               (SELECT u.Id FROM parts.user u WHERE u.Username = @username AND u.IsActive = 1 AND u.IsDeleted = 0),
                                                               @Workstation
                                                           );";
                #endregion


                /// <summary>
                /// Add Log in Printing. Accepts 3 parameters (@Imei, @printedBy, AND  @Workstation).
                /// </summary>
                #region AddPrintLogs
                public const string AddPrintLogs = @"INSERT INTO
                                                       printlogs 
                                                    VALUES
                                                       (
                                                           DEFAULT,
                                                           2,
                                                           @Imei,
                                                           NOW(),
                                                           @printedBy,
                                                           0,
                                                           @workstation
                                                       );";

                #endregion

                /// <summary>
                /// Check if IMEI is already printed label. Accepts 1 parameter (@Imei).
                /// </summary>
                #region IsPrinted
                public const string IsPrinted = @"  SELECT
                                                    IF
                                                        ( Count( * ) > 0, 1, 0 ) 
                                                    FROM
                                                             printlogs pl
                                                        JOIN receiving_table rt ON pl.IMEI = rt.imei
		
                                                        JOIN stock_shipment_unit ssu ON  ssu.device_imei = rt.imei
	                                                    JOIN stock_client_matrix scm ON scm.scm_id = ssu.scm_id
                                                    WHERE
                                                        rt.imei = @Imei
                                                        AND pl.AuthorizedBy = 0 
                                                        AND pl.LabelTypeId = 2
                                                        AND pl.PrintDate > rt.dateandtime
	                                                    AND scm.from_client = rt.clientcode;";
                #endregion


                /// <summary>
                /// Get IMEI Model. Accepts 1 parameter (@Imei).
                /// </summary>
                #region GetiPhoneModel
                public const string GetiPhoneModel = @"     SELECT
	                                                            rt.imei 'IMEI',
	                                                        CASE

						                                                        WHEN rt.modelname LIKE 'IP6 %' THEN 'iPhone 6'
						                                                        WHEN rt.modelname LIKE 'IP6S %' THEN 'iPhone 6s'
						                                                        WHEN rt.modelname LIKE 'IP6+ %' THEN 'iPhone 6 Plus'
						                                                        WHEN rt.modelname LIKE 'IP6S+ %' THEN 'iPhone 6s Plus'

						                                                        WHEN rt.modelname LIKE 'IP7 %' THEN 'iPhone 7'
						                                                        WHEN rt.modelname LIKE 'IP7+ %' THEN 'iPhone 7 Plus'
                                                                                WHEN rt.modelname LIKE 'IP8 %' THEN 'iPhone 8'
                                                                                WHEN rt.modelname LIKE 'IP8+ %' THEN 'iPhone 8 Plus'
                                                                                WHEN rt.modelname LIKE 'IPX %' THEN 'iPhone X'
						                                                        ELSE 'N/A'
					                                                        END 'Model',
	
					                                                        CASE
						                                                        WHEN rt.modelname LIKE '%16%' THEN '16GB'
						                                                        WHEN rt.modelname LIKE '%32%' THEN '32GB'
						                                                        WHEN rt.modelname LIKE '%64%' THEN '64GB'
						                                                        WHEN rt.modelname LIKE '%128%' THEN '128GB'
						                                                        WHEN rt.modelname LIKE '%256%' THEN '256GB'
						                                                        WHEN rt.modelname LIKE '%512%' THEN '512GB'

						                                                        ELSE 'N/A'
					                                                        END 'Size',
	
	
	                                                        CASE
						                                                        WHEN rt.modelname LIKE '%B' THEN 'Matte Black'
						                                                        WHEN rt.modelname LIKE '%BLU' THEN 'BLU'
						                                                        WHEN rt.modelname LIKE '%GLD' THEN 'Gold'
						                                                        WHEN rt.modelname LIKE '%GRN' THEN 'GRN'
						                                                        WHEN rt.modelname LIKE '%GRY' THEN 'Space Gray'
						                                                        WHEN rt.modelname LIKE '%PNK' THEN 'PNK'
						                                                        WHEN rt.modelname LIKE '%SVR' THEN 'Silver'
						                                                        WHEN rt.modelname LIKE '%WHT' THEN 'WHT'
						                                                        WHEN rt.modelname LIKE '%YLW' THEN 'YLW'
						                                                        WHEN rt.modelname LIKE '%RGD' THEN 'Rose Gold'
						                                                        WHEN rt.modelname LIKE '%BLK' THEN 'Matte Black'
						                                                        WHEN rt.modelname LIKE '%JBK' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%JBLK' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%JET' THEN 'Jet Black'
						                                                        WHEN rt.modelname LIKE '%RED' THEN 'Product Red'

						                                                        ELSE 'N/A'
					                                                        END 'Color'
	
                                                        FROM 
	                                                        tracking_system_1_schema.receiving_table rt
                                                        WHERE 
	                                                        rt.imei = @Imei;";
                #endregion
            }
        }

        public struct ChronosUK
        {
            public const string Name = "chronos_eco_uk";
            public struct Functions
            {

            }
            public struct Procedures
            {

            }
            public struct Queries
            {
                /// <summary>
                /// Get GetPhoneDetail. Accepts 1 parameter (@DeviceIMEI).
                /// </summary>
                #region GetPhoneDetail
                public const string GetPhoneDetail = @"  SELECT
	                                                    p.imei 'IMEI',
	                                                    m.model_alias 'Model',
	                                                    c.color_alias 'Color',
	                                                    s.phone_size 'Size',
	                                                    p.serial_number 'SerialNo',
	                                                    p.part_number 'PartNo',
                                                        'CHRONOS-UK' as 'Client'
                                                    FROM
	                                                    phone p
                                                    JOIN phone_configuration pc 
	                                                    ON pc.pc_id = p.pc_id
                                                    LEFT JOIN model m
	                                                    ON m.m_id = pc.m_id
                                                    LEFT JOIN color c
	                                                    ON c.c_id = pc.c_id
                                                    LEFT JOIN size s
	                                                    ON s.s_id = pc.s_id
                                                    WHERE p.imei = @DeviceIMEI
                                                    AND p.vr_id = 0";
                #endregion


                /// <summary>
                /// Add Log in Printing. Accepts 2 parameters (@Imei AND @printedBy).
                /// </summary>
                #region AddPrintLogs
                public const string AddPrintLogs = @"INSERT INTO print_logs
                                                    VALUES
	                                                    ( 
		                                                    DEFAULT,
		                                                    1,
		                                                    (SELECT p.p_id FROM phone p WHERE p.imei = @Imei AND p.vr_id = 0),
		                                                    @printedBy,
		                                                    DEFAULT,
		                                                    NOW()

	                                                    );";

                #endregion

                /// <summary>
                /// Check if IMEI is already printed label. Accepts 1 parameter (@Imei).
                /// </summary>
                #region IsPrinted
                public const string IsPrinted = @"  SELECT
                                                    IF
                                                        (COUNT( pl.pl_id ) > 0, 1, 0 ) 'IsPrinted' 
                                                    FROM
                                                        print_logs pl
                                                        JOIN phone p ON p.p_id = pl.p_id
                                                    WHERE

                                                        p.imei = @Imei

                                                        AND p.vr_id = 0;";
                #endregion

                /// <summary>
                /// Authenticate Print. Accepts 2 parameters (@Imei, @printedByid).
                /// </summary>
                #region AuthenticateUser
                public const string AuthenticateUser = @"UPDATE print_logs 
                                                        SET authorized_by_id = @printedByid 
                                                        WHERE
	                                                        p_id = ( 
                                                                SELECT 
                                                                    p.p_id 
                                                                FROM phone p 
                                                                WHERE p.imei = @Imei 
                                                                AND p.vr_id = 0 );";
                #endregion


                /// <summary>
                /// Get Hashed Password. Accepts 1 parameters (@username).
                /// </summary>
                #region GetPasswordHash
                public const string GetPasswordHash = @"   SELECT
                                                                    u.PASSWORD 
                                                                FROM
                                                                    parts.USER u 
                                                                WHERE
                                                                    u.username = @Username 
                                                                    AND u.UserTypeId IN ( 1, 35, 36 ) 
                                                                    AND u.IsActive = 1
                                                                    AND u.IsDeleted = 0;";
                #endregion

            }
        } 
    }
}
