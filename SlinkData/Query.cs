using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlinkData {
   public static class Query {
      public const String selectLinks = @"
         SELECT `links`.`id`, `links`.`url`, `links`.`comment`, `link_types`.`type_name`
         FROM `links` JOIN `link_types` ON `links`.`link_type` = `link_types`.`id`
         ORDER BY `link_types`.`type_name`;";

      public const String selectRanks = @"
         SELECT `id`, `rank_name`, `rank_value`, `comment`
         FROM `ranks`;";

      public const String selectTowns = @"
         SELECT `towns`.`id`, `towns`.`name`
         FROM `towns`
         ORDER BY `towns`.`name`;";

      public const String selectPeople = @"
         SELECT `people`.`id`, `people`.`forename`, `people`.`surname`, `people`.`alias`, `people`.`comment`
         FROM `people`
         ORDER BY `people`.`surname`;";

      public const String insertIntoClubs = @"
         INSERT INTO `clubs` (`id`, `name`, `town`, `link`, `rank`, `manager`, `e-mail`, `comment`)
         VALUES(NULL, @name, @town, @link, @rank, @manager, @email, @comment) ";

      public const String selectOccupations = @"
         SELECT `id`, `name`, `description`
         FROM `occupations`; ";

      public const String insertIntoPeople = @"
         INSERT INTO `people` (`id`, `forename`, `surname`, `alias`, `occupation`, `occupation2`, `phonenumber`, `e-mail`, `link`, `comment`)
         VALUES(NULL, @forename, @surname, @alias, @occupation, @occupation2, @phonenumber, @email, @link, @comment) ";

      public const String insertIntoFestivals = @"
         INSERT INTO `festivals` (`id`, `name`, `town`, `link`, `e-mail`, `start_date`,`application_date`, `manager`,`rank`,  `comment`)
         VALUES(NULL, @name, @town,@link, @email, @start, @application,@manager,@rank, @comment) ";

      public const String selectLinkTypes = @"
         SELECT `id`, `type_name`, `description`
         FROM `link_types`; ";

      public const String insertIntoLinks = @"
         INSERT INTO `links` (`id`, `link_type`, `url`, `comment`)
         VALUES(NULL, @link_type, @url, @comment) ";

      public const String selectTownSizes = @"
         SELECT `id`, `size_name`, `lower_limit`, `upper_limit`, `comment`
         FROM `town_sizes`; ";

      public const String insertIntoTowns = @"
         INSERT INTO `towns` (`id`, `name`, `size`, `distance` ,`comment`)
         VALUES(NULL, @name, @size, @distance, @comment) ";

      public const String showFestivals = @"
         SELECT   `festivals`.`id`,
                  `festivals`.`name`,
                  `towns`.`name` AS `town`,
                  `links`.`url` AS `link`,
                  `festivals`.`e-mail`,
                  DATE_FORMAT(`festivals`.`start_date`,'%Y-%m-%d'),
                  DATE_FORMAT(`festivals`.`application_date`,'%Y-%m-%d'),
                  CONCAT(COALESCE(`people`.`forename`, ''), ' <', COALESCE(`people`.`alias`, ''), '> ',COALESCE(`people`.`surname`, '')) AS `manager`,
                  `ranks`.`rank_name` AS `rank`,
                  `festivals`.`comment`
         FROM     `festivals`
         LEFT JOIN `links` ON( `festivals`.`link` IS NOT NULL AND `festivals`.`link` = `links`.`id`)
         LEFT JOIN `people`ON(`festivals`.`manager` IS NOT NULL AND `festivals`.`manager` = `people`.`id`)
         LEFT JOIN `ranks` ON(`festivals`.`rank` IS NOT NULL AND `festivals`.`rank` = `ranks`.`id`)
         LEFT JOIN `towns` ON( `festivals`.`town` IS NOT NULL AND `festivals`.`town` = `towns`.`id`)
         ORDER BY `name`; ";

      public const String showLinks = @"
         SELECT   `links`.`id`,
                  `links`.`url`,
                  `links`.`comment`,
                  `link_types`.`type_name`
         FROM     `links`
         JOIN `link_types` ON `links`.`link_type` = `link_types`.`id`
         ORDER BY `link_types`.`type_name`;";

      public const String showPeople = @"
         SELECT 	`people`.`id`,
                  CONCAT( COALESCE(`people`.`forename`, ''),' <',COALESCE(`people`.`alias`, ''),'> ',COALESCE(`people`.`surname`, '')) AS `name`,
                  `people`.`phonenumber`,
                  `people`.`e-mail`,
                  `people`.`comment`,
                  `links`.`url` AS `link_name`,
                  `occ1`.`name` AS `occupation 1`,
                  `occ2`.`name` AS `occupation 2`
         FROM     `people`
         LEFT JOIN `links` ON( `people`.`link` IS NOT NULL AND `people`.`link` = `links`.`id`)
         LEFT JOIN `occupations` `occ1` ON(`people`.`occupation` IS NOT NULL AND `people`.`occupation` = `occ1`.`id`)
         LEFT JOIN `occupations` `occ2` ON(`people`.`occupation2` IS NOT NULL AND `people`.`occupation2` = `occ2`.`id`)
         ORDER BY `name`; ";

      public const String showPubs = @"
         SELECT 	`clubs`.`id`,
                  `clubs`.`name` AS `club_name`,
                  `towns`.`name` AS `town`,
                  `ranks`.`rank_name` AS `rank`,
                  CONCAT(COALESCE(`people`.`forename`, ''), ' <',COALESCE(`people`.`alias`,''), '> ',COALESCE(`people`.`surname`,'')) AS `manager`,
                  `clubs`.`e-mail`,
                  `links`.`url` AS `link`,
                  `clubs`.`comment`
         FROM `clubs`
         LEFT JOIN `towns`ON (`clubs`.`town` IS NOT NULL AND `clubs`.`town` = `towns`.`id`)
         LEFT JOIN `ranks` ON (`clubs`.`rank` IS NOT NULL AND `clubs`.`rank` = `ranks`.`id`)
         LEFT JOIN `people`ON (`clubs`.`manager` IS NOT NULL AND `clubs`.`manager` = `people`.`id`)
         LEFT JOIN `links` ON (`clubs`.`link` IS NOT NULL AND`clubs`.`link` = `links`.`id`)
         ORDER BY `clubs`.`rank` DESC; ";

      public const String showTowns = @"
         SELECT   `towns`.`id`,
                  `towns`.`name`,
                  `towns`.`distance`,
                  `town_sizes`.`size_name`
         FROM `towns`
         JOIN `town_sizes`ON `towns`.`size` = `town_sizes`.`id`
         ORDER BY `towns`.`name`;";

      public const String selectFestival = @"
         SELECT * 
         FROM `festivals`
         WHERE `id`= @id;";

      public const String updateFestival = @"
         UPDATE `festivals`
         SET `name` = @name, `town` = @town, `link` = @link, `e-mail` = @email, `start_date` = @start, `application_date` = @application, `manager` = @manager, `comment` = @comment
         WHERE `festivals`.`id` = @id ;";

      public const String selectLink = @"
         SELECT * 
         FROM `links`
         WHERE `id`= @id;";

      public const String updateLink = @"
         UPDATE `links`
         SET `link_type` = @link_type, `url` = @url, `comment` = @comment
         WHERE `links`.`id` = @id ;";

      public const String selectTown = @"
         SELECT * 
         FROM `towns`
         WHERE `id`= @id;";

      public const String updateTown = @"
         UPDATE `towns`
         SET `name` = @name, `size` = @size, `distance` = @distance, `comment` = @comment
         WHERE `towns`.`id` = @id ;";

      public const String selectPub = @"
         SELECT * 
         FROM `clubs`
         WHERE `id`= @id;";

      public const String updatePub = @"
         UPDATE `clubs`
         SET `name` = @name, `town` = @town, `link` = @link, `rank` = @rank, `manager` = @manager, `e-mail` = @email, `comment` = @comment
         WHERE `clubs`.`id` = @id ;";

      public const String selectPerson = @"
         SELECT * 
         FROM `people`
         WHERE `id`= @id;";

      public const String updatePerson = @"
         UPDATE `people`
         SET `forename` = @forename, `surname` = @surname, `alias` = @alias, `occupation` = @occupation, `occupation2` = @occupation2, `phonenumber` = @phonenumber, `e-mail` = @email, `link` = @link, `comment` = @comment
         WHERE `people`.`id` = @id ;";
   }
}