#Culture Id, Name, Group, GroupId
#CultureCompatibility Id, SpeciesId, NeghbourId, CompatibilityGrade, Note

import pyodbc
import pandas as pd
import sys

sys.stdout.reconfigure(encoding='utf-8')

def read_excel_file(file_path, table_name):
    # Load Excel data 
    table_data = pd.read_excel(file_path, sheet_name=table_name)
    return table_data

def connect_to_database():
    connection_string = (
        'DRIVER=SQL Server;'
        'SERVER=DESKTOP-UBN63ES\\SQLEXPRESS;'
        'DATABASE=UltimumBotanicaDb;'
        'Trusted_Connection=yes;'
    )
 
    try:
        connection = pyodbc.connect(connection_string)
        print("Connected to the database.")
        return connection
    except Exception as e:
        print(f"Failed to connect to the database: {e}")
        return None
   
def insert_data_from_excel(table_name, table_data):
    # Read Excel data into a DataFrame
    connection = connect_to_database()
    if connection is None:
        return

    if table_name == "Culture":
        columns = [f"[{col}]" for col in table_data.columns]
        cursor = connection.cursor()

        # Iterate over the rows of the DataFrame and insert them into the database
        for index, row in table_data.iterrows():
            try:
                # Construct the SQL query with placeholders for each value
                sql = f"""INSERT INTO {table_name} ({columns[0]}, {columns[1]}, {columns[2]})
                        VALUES (?, ?, ?)"""
                # Execute the query with the values from the current row
                cursor.execute(sql, (row[table_data.columns[0]], 
                                    row[table_data.columns[1]], 
                                    row[table_data.columns[2]]))
                

            except Exception as e:
                print(f"Error inserting row {index + 1}: {e}")

    if table_name == "CultureComapatibility":
        columns = [f"[{col}]" for col in table_data.columns]
        cursor = connection.cursor()

        # Iterate over the rows of the DataFrame and insert them into the database
        for index, row in table_data.iterrows():
            try:
                # Construct the SQL query with placeholders for each value
                sql = f"""INSERT INTO {table_name} ({columns[0]}, {columns[1]}, {columns[2]}, {columns[3]})
                        VALUES (?, ?, ?, ?)"""
                # Execute the query with the values from the current row
                cursor.execute(sql, (row[table_data.columns[0]], 
                                    row[table_data.columns[1]], 
                                    row[table_data.columns[2]],
                                    row[table_data.columns[3]]))
                

            except Exception as e:
                print(f"Error inserting row {index + 1}: {e}")

    # Commit the transaction and close the connection
    connection.commit()
    cursor.close()
    connection.close()
    print("Data inserted successfully.")

def main():
    excel_file = "C:\\Users\\Korisnik\\Downloads\\tablice.xlsx"
    table_names = ["Culture", "CultureComapatibility"] #Input as many tables names as you need
    tables_data = [] #Here will be saved all data from each table in 'table_names'
 
    # Read the Excel data

    for table_name in table_names:
        tables_data.append(read_excel_file(excel_file, table_name))
 
    # Connect to the database
    connection = connect_to_database()
    if connection:
        # Insert the data into the database
        for i in range(len(table_names)):
            insert_data_from_excel(table_names[i], tables_data[i])

        # insert_data_from_excel(table_names[0], tables_data[0])
 
        # Close the database connection
        connection.close()
        print("Database connection closed.")
 

main()

