
Create a C# program to manage a photo book using object-oriented programming.To start, 
1.create a class called PhotoBook with a private attribute numPages of type int. 
2.It must also have a public method GetNumberPages that will return the number of photo book pages.
3.The default constructor will create an album with 16 pages. There will be an additional constructor, with which we can specify 
the number of pages we want in the album.
4.There is also a BigPhotoBook class whose constructor will create an album with 64 pages.
5.Finally create a class to perform the following actions:Create a default photo book and show the number of pages
6.Create a photo book with 24 pages and show the number of pages
7.Create a large photo book and show the number of pages

using System;
public class Photobook
	{
	protected int numpages;
	public int Getnumberpages()
	{
		return numpages;
	}
	public  Photobook()
	{
	 	 numpages=16;
	}
	public Photobook(int addpages)
	{
		numpages=addpages;	
	}
}
	class BigPhotoBook : Photobook
	{
	public  BigPhotoBook()
	{
	  numpages=64;	
	}
		
	}
	public class testclass
	{
	
	public static void Main(string[] args)
	{
		Photobook album = new Photobook();
		Console.WriteLine(album.Getnumberpages());
		Photobook album1 = new Photobook(24);
		Console.WriteLine(album1.Getnumberpages());
		BigPhotoBook album2 = new BigPhotoBook();
		Console.WriteLine(album2.Getnumberpages());
		
		
	}
}


