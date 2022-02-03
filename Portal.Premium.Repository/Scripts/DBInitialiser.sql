--SqlLocalDB create PremiumPortal 
 /*OccupationRating script start here */

  IF NOT EXISTS(SELECT 1 from [OccupationRating] WHERE [Rating]='Professional')
  BEGIN
	INSERT INTO [OccupationRating] ([Factor],[Rating]) VALUES (1.0,'Professional')
  END


  IF NOT EXISTS(SELECT 1 from [OccupationRating] WHERE [Rating]='White Collar')
  BEGIN
	INSERT INTO [OccupationRating] ([Factor],[Rating]) VALUES (1.25,'White Collar')
  END

  IF NOT EXISTS(SELECT 1 from [OccupationRating] WHERE [Rating]='Light Manual')
  BEGIN
	INSERT INTO [OccupationRating] ([Factor],[Rating]) VALUES (1.50,'Light Manual')
  END

  IF NOT EXISTS(SELECT 1 from [OccupationRating] WHERE [Rating]='Heavy Manual')
  BEGIN
	INSERT INTO [OccupationRating] ([Factor],[Rating]) VALUES (1.75,'Heavy Manual')
  END

  /*Occupation script start here */

  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Cleaner')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Cleaner',3);
  END
  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Doctor')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Doctor',1);
  END
  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Author')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Author',2);
  END
  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Farmer')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Farmer',4);
  END
  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Mechanic')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Mechanic',4);
  END  
  IF NOT EXISTS(SELECT 1 from [Occupation] WHERE [Occupation]='Florist')
  BEGIN
	INSERT INTO [Occupation] ([Occupation],[RatingId]) VALUES('Florist',3);
  END