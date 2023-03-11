CREATE TABLE user (
    user_id varchar(30),
    umur int
);
INSERT INTO user VALUES
    ('wildan', 27),
    ('zaki', 25);

CREATE TABLE asset (
    nomor int,
    item varchar(30),
    user_id varchar(30),
    PRIMARY KEY (nomor)
);
INSERT INTO asset VALUES
    (1, 'notebook', 'wildan'),
    (2, 'bag', 'wildan'),
    (3, 'notebook', 'zaki'),
    (4, 'bag', 'zaki'),
    (5, 'mobile phone', 'zaki');

--query test 1
SELECT item from asset WHERE user_id = 'zaki';

-- query test 2
SELECT a.user_id, asset = STUFF( (SELECT ',' + item FROM asset FOR XML PATH (''), 1, 1, '') 
FROM user a
INNER JOIN asset
ON a.user_id = asset.user_id;
