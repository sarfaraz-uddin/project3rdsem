create table customer(
firstname	varchar(50)	not null,
lastname	varchar(50)	not null,
address		varchar(100)	not null,
city		varchar(20)		not null,
state		varchar(40)		not null,
country		varchar(50)		not null,
email		varchar(50)		null
)

insert into customer values('sarfaraz', 'uddin', 'bagbazar', 'kathmandu', 'nepal', 'sarfu@sarfu.com') 