// app/languages/page.tsx
'use client';  // This is to indicate that this is a client-side component

import React, { useEffect, useState } from 'react';
import { fetchLanguages } from '@/services/api';  // Import the API call

const LanguagesPage = () => {
    const [languages, setLanguages] = useState<any[]>([]);  // State to store languages data
    const [error, setError] = useState<string | null>(null);  // State to store error message
    const [loading, setLoading] = useState<boolean>(true); // Loading state to display a loading message

    useEffect(() => {
        const loadLanguages = async () => {
            try {
                const data = await fetchLanguages();  // Call API to get all languages
                setLanguages(data);  // Store data in state
            } catch (error: any) {
                setError('Failed to load languages.');  // Set error message if API call fails
            } finally {
                setLoading(false);  // Stop loading when data is fetched or error occurs
            }
        };

        loadLanguages();  // Call the function when the component is mounted
    }, []);  // Empty dependency array to run the effect only once when the component mounts

    if (loading) {
        return <div>Loading...</div>;
    }

    if (error) {
        return <div>Error: {error}</div>;
    }

    return (
        <div>
            <h1>Languages</h1>
            <ul>
                {languages.map((language: any) => (
                    <li key={language.id}>{language.name}</li>
                ))}
            </ul>
        </div>
    );
};

export default LanguagesPage;
