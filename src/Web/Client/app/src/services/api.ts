const API_BASE_URL = process.env.NEXT_PUBLIC_API_URL || "https://localhost:7241"

const handleResponse = async (response: Response) => {
    if (!response.ok) {
        throw new Error('Network response was not ok');
    }
    return response.json();
};

// GET all languages
export const fetchLanguages = async () => {
    const response = await fetch(`${API_BASE_URL}/api/languages`);
    return handleResponse(response);
};

// GET a single language by ID
export const fetchLanguageById = async (id: string) => {
    const response = await fetch(`${API_BASE_URL}/api/languages/${id}`);
    return handleResponse(response);
};

// POST a new language
export const createLanguage = async (language: { name: string }) => {
    const response = await fetch(`${API_BASE_URL}/api/languages`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(language),
    });
    return handleResponse(response);
};

// PUT (update) a language
export const updateLanguage = async (id: string, language: { name: string }) => {
    const response = await fetch(`${API_BASE_URL}/api/languages/${id}`, {
        method: 'PUT',
        headers: {
            'Content-Type': 'application/json',
        },
        body: JSON.stringify(language),
    });
    return handleResponse(response);
};

// DELETE a language
export const deleteLanguage = async (id: string) => {
    const response = await fetch(`${API_BASE_URL}/api/languages/${id}`, {
        method: 'DELETE',
    });
    return handleResponse(response);
};
