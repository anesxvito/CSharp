
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.IO
Imports System.Linq

Public Module Extensions_763

	''' <summary>
	'''     Returns an enumerable collection of file names in a specified @this.
	''' </summary>
	''' <param name="this">The directory to search.</param>
	''' <returns>
	'''     An enumerable collection of the full names (including paths) for the files in the directory specified by
	'''     <paramref
	'''         name="this" />
	'''     .
	''' </returns>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this " />is a zero-length string, contains only
	'''     white space, or contains invalid characters as defined by
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     <paramref name="this" /> is invalid, such as
	'''     referring to an unmapped drive.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">
	'''     <paramref name="this" /> is a file name.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or combined exceed the
	'''     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
	'''     and file names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EnumerateFiles(this As DirectoryInfo) As IEnumerable(Of FileInfo)
		Return Directory.EnumerateFiles(this.FullName).[Select](Function(x) New FileInfo(x))
	End Function

	''' <summary>
	'''     Returns an enumerable collection of file names that match a search pattern in a specified @this.
	''' </summary>
	''' <param name="this">The directory to search.</param>
	''' <param name="searchPattern">
	'''     The search string to match against the names of directories in
	'''     <paramref name="this" />.
	''' </param>
	''' <returns>
	'''     An enumerable collection of the full names (including paths) for the files in the directory specified by
	'''     <paramref
	'''         name="this" />
	'''     and that match the specified search pattern.
	''' </returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this " />is a zero-length string, contains only
	'''     white space, or contains invalid characters as defined by
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.-or-
	'''     <paramref name="searchPattern" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     <paramref name="this" /> is invalid, such as
	'''     referring to an unmapped drive.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">
	'''     <paramref name="this" /> is a file name.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or combined exceed the
	'''     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
	'''     and file names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EnumerateFiles(this As DirectoryInfo, searchPattern As [String]) As IEnumerable(Of FileInfo)
		Return Directory.EnumerateFiles(this.FullName, searchPattern).[Select](Function(x) New FileInfo(x))
	End Function

	''' <summary>
	'''     Returns an enumerable collection of file names that match a search pattern in a specified @this, and
	'''     optionally searches subdirectories.
	''' </summary>
	''' <param name="this">The directory to search.</param>
	''' <param name="searchPattern">
	'''     The search string to match against the names of directories in
	'''     <paramref name="this" />.
	''' </param>
	''' <param name="searchOption">
	'''     One of the enumeration values that specifies whether the search operation should
	'''     include only the current directory or should include all subdirectories.The default value is
	'''     <see
	'''         cref="F:System.IO.SearchOption.TopDirectoryOnly" />
	'''     .
	''' </param>
	''' <returns>
	'''     An enumerable collection of the full names (including paths) for the files in the directory specified by
	'''     <paramref
	'''         name="this" />
	'''     and that match the specified search pattern and option.
	''' </returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this " />is a zero-length string, contains only
	'''     white space, or contains invalid characters as defined by
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.-or-
	'''     <paramref name="searchPattern" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentOutOfRangeException">
	'''     <paramref name="searchOption" /> is not a valid
	'''     <see cref="T:System.IO.SearchOption" /> value.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     <paramref name="this" /> is invalid, such as
	'''     referring to an unmapped drive.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">
	'''     <paramref name="this" /> is a file name.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or combined exceed the
	'''     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
	'''     and file names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EnumerateFiles(this As DirectoryInfo, searchPattern As [String], searchOption As SearchOption) As IEnumerable(Of FileInfo)
		Return Directory.EnumerateFiles(this.FullName, searchPattern, searchOption).[Select](Function(x) New FileInfo(x))
	End Function

	''' <summary>
	'''     Returns an enumerable collection of file names that match a search pattern in a specified @this.
	''' </summary>
	''' <param name="this">The directory to search.</param>
	''' <param name="searchPatterns">The search string to match against the names of directories in.</param>
	''' <returns>
	'''     An enumerable collection of the full names (including paths) for the files in the directory specified by
	'''     <paramref
	'''         name="this" />
	'''     and that match the specified search pattern.
	''' </returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' ###
	''' <param name="searchPattern">
	'''     The search string to match against the names of directories in
	'''     <paramref name="this" />.
	''' </param>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this " />is a zero-length string, contains only
	'''     white space, or contains invalid characters as defined by
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.-or-
	'''     <paramref name="searchPattern" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     <paramref name="this" /> is invalid, such as
	'''     referring to an unmapped drive.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">
	'''     <paramref name="this" /> is a file name.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or combined exceed the
	'''     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
	'''     and file names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EnumerateFiles(this As DirectoryInfo, searchPatterns As [String]()) As IEnumerable(Of FileInfo)
		Return searchPatterns.SelectMany(Function(x) this.GetFiles(x)).Distinct()
	End Function

	''' <summary>
	'''     Returns an enumerable collection of file names that match a search pattern in a specified @this, and
	'''     optionally searches subdirectories.
	''' </summary>
	''' <param name="this">The directory to search.</param>
	''' <param name="searchPatterns">
	'''     The search string to match against the names of directories in
	'''     <paramref name="this" />.
	''' </param>
	''' <param name="searchOption">
	'''     One of the enumeration values that specifies whether the search operation should
	'''     include only the current directory or should include all subdirectories.The default value is
	'''     <see
	'''         cref="F:System.IO.SearchOption.TopDirectoryOnly" />
	'''     .
	''' </param>
	''' <returns>
	'''     An enumerable collection of the full names (including paths) for the files in the directory specified by
	'''     <paramref
	'''         name="this" />
	'''     and that match the specified search pattern and option.
	''' </returns>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' <example>
	'''     <code>
	'''       using System;
	'''       using System.Collections.Generic;
	'''       using System.IO;
	'''       using System.Linq;
	'''       using Microsoft.VisualStudio.TestTools.UnitTesting;
	''' 
	'''       namespace ExtensionMethods.Examples
	'''       {
	'''           [TestClass]
	'''           public class System_IO_DirectoryInfo_EnumerateFiles
	'''           {
	'''               [TestMethod]
	'''               public void EnumerateFiles()
	'''               {
	'''                   // Type
	'''                   var root = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, &quot;System_IO_DirectoryInfo_EnumerateFiles&quot;));
	'''                   Directory.CreateDirectory(root.FullName);
	''' 
	'''                   var file1 = new FileInfo(Path.Combine(root.FullName, &quot;test1.txt&quot;));
	'''                   var file2 = new FileInfo(Path.Combine(root.FullName, &quot;test2.txt&quot;));
	'''                   file1.Create();
	'''                   file2.Create();
	''' 
	'''                   // Exemples
	'''                   List&lt;FileInfo&gt; result = root.EnumerateFiles().ToList();
	''' 
	'''                   // Unit Test
	'''                   Assert.AreEqual(2, result.Count);
	'''               }
	'''           }
	'''       }
	''' </code>
	''' </example>
	''' ###
	''' <exception cref="T:System.ArgumentException">
	'''     <paramref name="this " />is a zero-length string, contains only
	'''     white space, or contains invalid characters as defined by
	'''     <see
	'''         cref="M:System.IO.Path.GetInvalidPathChars" />
	'''     .- or -<paramref name="searchPattern" /> does not contain a valid pattern.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentNullException">
	'''     <paramref name="this" /> is null.-or-
	'''     <paramref name="searchPattern" /> is null.
	''' </exception>
	''' ###
	''' <exception cref="T:System.ArgumentOutOfRangeException">
	'''     <paramref name="searchOption" /> is not a valid
	'''     <see cref="T:System.IO.SearchOption" /> value.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.DirectoryNotFoundException">
	'''     <paramref name="this" /> is invalid, such as
	'''     referring to an unmapped drive.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.IOException">
	'''     <paramref name="this" /> is a file name.
	''' </exception>
	''' ###
	''' <exception cref="T:System.IO.PathTooLongException">
	'''     The specified @this, file name, or combined exceed the
	'''     system-defined maximum length. For example, on Windows-based platforms, paths must be less than 248 characters
	'''     and file names must be less than 260 characters.
	''' </exception>
	''' ###
	''' <exception cref="T:System.Security.SecurityException">The caller does not have the required permission.</exception>
	''' ###
	''' <exception cref="T:System.UnauthorizedAccessException">The caller does not have the required permission.</exception>
	<System.Runtime.CompilerServices.Extension> _
	Public Function EnumerateFiles(this As DirectoryInfo, searchPatterns As [String](), searchOption As SearchOption) As IEnumerable(Of FileInfo)
		Return searchPatterns.SelectMany(Function(x) this.GetFiles(x, searchOption)).Distinct()
	End Function
End Module


