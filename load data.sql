use decanat;


SET FOREIGN_KEY_CHECKS=1;

LOAD DATA LOCAL INFILE 'C:/Users/artik/Desktop/app/data/results.txt' INTO TABLE results
  FIELDS TERMINATED BY ' '
  LINES TERMINATED BY '\r\n'
  IGNORE 1 LINES;
  

